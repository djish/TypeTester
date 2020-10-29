using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class InputSpeed
    {
        public string Name { get; set; }

        public string Speed { get; set; }

        public int Characters { get; set; }

        public int Spaces { get; set; }

        public int Words { get; set; }

        public int Paragraphs { get; set; }

        public float WordsPerMinute { get; set; }
    }
}
