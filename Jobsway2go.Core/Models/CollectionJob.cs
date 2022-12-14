using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class CollectionJob
    {
        public int JobId { get; set; }
        public Job job { get; set; }

        public int CollectionId { get; set; }
        public Collection collection { get; set; }
    }
}
