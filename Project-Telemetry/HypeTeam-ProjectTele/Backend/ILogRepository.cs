using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HypeTeam_ProjectTele.Models;

namespace HypeTeam_ProjectTele.Backend
{
    public interface ILogRepository
    {
        LogModel Create(LogModel data);
        LogModel Read(String id);
        LogModel Update(LogModel data);
        Boolean Delete(String id);
        List<LogModel> Index();
    }
}