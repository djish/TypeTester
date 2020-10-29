using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DataManager
{
    public class SpeedDataHandler : DataHandler
    {

        private static SpeedDataHandler instance = null;

        private SpeedDataHandler() { }

        public static SpeedDataHandler GetInstance()
        {
            if(null == instance)
            {
                instance = new SpeedDataHandler();
            }
            return instance;
        }

        public bool SetupUser(string registerNumber)
        {
            bool isSetup = false;

            try
            {
                var speedSaveFolder = System.Configuration.ConfigurationManager.AppSettings["output_speed_folder"];
                if( ! Directory.Exists(speedSaveFolder)) {
                    Directory.CreateDirectory(speedSaveFolder);
                }

                string userFolder = speedSaveFolder + registerNumber;
                if (!Directory.Exists(userFolder)) {
                    Directory.CreateDirectory(userFolder);
                }

                isSetup = true;
            }
            catch(Exception ex)
            {
                Logger.Logger.LogException(ex.Message);
            }
            return isSetup;
        }

        

        public List<Intervals> GetSpeedIntervals()
        {
            List<Intervals> intervalList = new List<Intervals>();

            for(int index = 5; index <= 30; index+=5)
            {
                Intervals interval = new Intervals();
                interval.Interval = index;
                interval.Name = index + " Minutes";

                intervalList.Add(interval);
            }

            return intervalList;
        }
    }
}
