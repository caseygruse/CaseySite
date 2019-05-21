using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaseySite.Models
{  
    public static class DbHelper
    {
        public static CaseyContext Context = new CaseyContext();

        public static List<Project> GetProjects()
        {
           return Context.Projects.ToList();
        }

    }
}