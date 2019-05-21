using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HypeTeam_ProjectTele.Models
{
    public class LogModel
    {
        public string ID { get; set; } = Guid.NewGuid().ToString();
        public string Value { get; set; }
        public DateTime RecordedDateTime { get; set; } = DateTime.Now;
        public string PhoneID { get; set; }
        public string AppVersion { get; set; }
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

            Value = data.Value;
            RecordedDateTime = data.RecordedDateTime;
            PhoneID = data.PhoneID;
            AppVersion = data.AppVersion;

            return true;
        }
    }
}