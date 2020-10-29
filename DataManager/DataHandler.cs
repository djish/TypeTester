using Entities;
using SpeedAnalyzer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class DataHandler
    {

        private string speedInputFolder = string.Empty;
        private string speedOutputFolder = string.Empty;

        public DataHandler()
        {
            this.speedInputFolder = System.Configuration.ConfigurationManager.AppSettings["input_speed_folder"];
            this.speedOutputFolder = System.Configuration.ConfigurationManager.AppSettings["output_speed_folder"];
        }

        public bool SetupEnvironment()
        {
            bool isSetup = false;

            try
            {
                CreateLanguageFolder(Language.English.ToString());
                CreateLanguageFolder(Language.Malayalam.ToString());

            }
            catch (Exception ex)
            {
                Logger.Logger.LogException(ex.Message);
            }
            return isSetup;
        }

        private bool CreateLanguageFolder(string language)
        {
            bool isSetup = false;
            try
            {
                CreateDirectoryIfNotExists(this.speedInputFolder + language.ToLower());

                CreateStreamFolder(language, Entities.Stream.Lower.ToString());
                CreateStreamFolder(language, Entities.Stream.Higher.ToString());


                isSetup = true;
            }
            catch (Exception ex)
            {
                Logger.Logger.LogException(ex.Message);
            }

            return isSetup;
        }

        private void CreateStreamFolder(string language, string stream)
        {
            CreateDirectoryIfNotExists(this.speedInputFolder + language.ToLower() + "/" + stream.ToLower()) ;
        }

        private bool CreateDirectoryIfNotExists(string directoryPath)
        {
            if( ! Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            return true;
        }

        protected List<Speed> GetSpeeds(Language language, Entities.Stream stream)
        {
            List<Speed> speeds = new List<Speed>();
            string speedfolder = this.speedInputFolder + language.ToString().ToLower() + "/" + stream.ToString().ToLower() + "/";
            foreach (string file in Directory.EnumerateFiles(speedfolder, "*.txt"))
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                Speed speed = new Speed(fileName);
                speed.Path = file;
                speeds.Add(speed);
            }

            return speeds;
        }

        protected Speed GetSpeedMetadata(Speed speed)
        {
            speed.SpeedText = ReadSpeedText(speed.Path);
            return SpeedPropertyExtractor.GetSpeedProperties(speed);
        }

        private string ReadSpeedText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
