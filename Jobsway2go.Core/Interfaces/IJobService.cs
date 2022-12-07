using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    internal interface IJobService
    {
        public void SearchJob();
        public void FilterByCategory(string category);
        public void FilterByCity(string city);
        public void ApplyForJob();
        public void UserSaveJob();
    }
}
