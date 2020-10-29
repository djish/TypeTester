using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class User
    {
        public string RegisterNumber { get; set; }

        public Stream Stream { get; set; }

        public Language Language { get; set; }

        public InputType InputType { get; set; }

        public InputSpeed Speed { get; set; }

        public Intervals Interval { get; set; }

        public Result Result { get; set; }
    }
}
