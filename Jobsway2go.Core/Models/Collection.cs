using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public string Name { get; set; }
        public List<Job> Job { get; set; }
        public List<Post> Post { get; set; }

        public List<CollectionPost> CollectionPost { get; set; }
        public List<CollectionJob> CollectionJob { get; set; }
    }
}
