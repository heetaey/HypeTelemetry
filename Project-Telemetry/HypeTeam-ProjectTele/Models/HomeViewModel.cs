using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HypeTeam_ProjectTele.Models
{
    public class HomeViewModel
    {
        public LogViewModel LogViewModel2 { get; set; } = new LogViewModel();
        public int LogCount { get; set; }
        public int PhoneCount { get; set; }
        public int OSCount { get; set; }
    }
}