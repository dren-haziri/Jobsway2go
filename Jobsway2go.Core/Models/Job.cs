using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Location { get; set; }
        public string Schedule { get; set; }
        public string Description { get; set; }
        public int OpenSpots { get; set; }
        public string Requirements { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public decimal Payment { get; set; }
        //public List<User> Applicants { get; set; }
        public List<CollectionJob> CollectionJob { get; set; }
    }
}
