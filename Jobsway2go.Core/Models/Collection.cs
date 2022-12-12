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
        public List<ApplicationUser> UserId { get; set; }
        public string Name { get; set; }
        public List<Job> Job { get; set; }
        public List<Post> Post { get; set; }
    }
}
