using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace HypeTeam_ProjectTele.Models
{
    public static class RandomGen2
    {
        private static Random _global = new Random();
        [ThreadStatic]
        private static Random _local;

        public static int Next()
        {
            Random inst = _local;
            if (inst == null)
            {
                int seed;
                lock (_global) seed = _global.Next();
                _local = inst = new Random(seed);
            }
            return inst.Next(0, 100000);
        }
    }

    public class LogModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string PatientID { get; set; } = RandomGen2.Next().ToString("D6");
        public string Value { get; set; }
        public DateTime RecordedDateTime { get; set; } = DateTime.Now;
        public string PhoneID { get; set; }
        public string AppVersion { get; set; }
        public string Location { get; set; }
        public string UserID { get; set; }
        public string PhoneHome { get; set; }
        public string OsVersion { get; set; }
        public string LightLevel { get; set; }
        public string SaturationLevel { get; set; }
        public string HueLevel { get; set; }
        public string ClinicID { get; set; }

        public LogModel()
        {
            Initialize();
        }
        public void Initialize()
        {

        }

        /// <summary>
        /// Update fields passed in
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Update(LogModel data)
        {
            if (data == null)
            {
                return false;
            }

            ID = data.ID;
            Value = data.Value;
            //RecordedDateTime = data.RecordedDateTime;
            PhoneID = data.PhoneID;
            AppVersion = data.AppVersion;
            Location = data.Location;
            UserID = data.UserID;
            OsVersion = data.OsVersion;
            LightLevel = data.LightLevel;
            SaturationLevel = data.SaturationLevel;
            HueLevel = data.HueLevel;
            ClinicID = data.ClinicID;

            return true;
        }
    }
}