using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Result
    {
        public DateTime StartTime { get; set; }

        public DateTime ExpectedEndTime { get; set; }
        
        public DateTime ActualEndTime { get; set; }

        public Speed ResultSpeed { get; set; }

        public float Score { get; set; }
    }
}
