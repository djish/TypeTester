using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;

namespace SpeedAnalyzer
{
    public static class SpeedPropertyExtractor
    {
        public static Speed GetSpeedProperties(Speed speed)
        {
            // Initializing counters 
            int countWord = 0;
            int sentenceCount = 0;
            int characterCount = 0;
            int paragraphCount = 1;
            int whitespaceCount = 0;

            paragraphCount = speed.SpeedText.Split(new[] { Environment.NewLine },
                                                    StringSplitOptions.RemoveEmptyEntries).Count();

            // Reading line by line from the  
            // file until a null is returned 
            foreach (string line in speed.SpeedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if ( ! line.Equals(""))
                {
                    characterCount += line.Length;

                    countWord += CountWords(line);
                    whitespaceCount += countWord - 1;

                    // [!?.:]+ is the sentence delimiter in java 
                    string[] sentenceList = Regex.Split(line, @"(?<=['""A-Za-z0-9][\.\!\?])\s+(?=[A-Z])");
                    sentenceCount += sentenceList.Length;
                }
            }

            speed.Characters = characterCount;
            speed.Paragraphs = paragraphCount;
            speed.Words = countWord;
            speed.Spaces = whitespaceCount;
            speed.Sentences = sentenceCount;

            return speed;
        }

        private static int CountWords(string word)
        {
            int count = 1;
            int a = 0;
            while (a <= word.Length - 1)
            {
                if (word[a] == ' ' || word[a] == '\n' || word[a] == '\t')
                {
                    count++;
                }
                a++;
            }

            return count;
        }
    }
}
