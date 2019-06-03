using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HypeTeam_ProjectTele.Models
{
    public class ReportViewModel
    {
        public LogViewModel LogViewModel { get; set; } = new LogViewModel();
        public int NumberOfUsers { get; set; }
    }
}