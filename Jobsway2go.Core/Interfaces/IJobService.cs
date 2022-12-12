using Jobsway2go.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IJobService: IRepository<Job>
    {
         Job SearchJob(int jobToSearchId);
         List<Job> FindAll();
        //public void FilterByCategory(string category);
        Job FilterByLocation(string jobToSearchLocation);
        //public void ApplyForJob();
        //public void UserSaveJob();
        IEnumerable<Job> ListJobs();
    }
}
