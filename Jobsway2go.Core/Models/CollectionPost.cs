using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class CollectionPost
    {
        public int PostId { get; set; }
        public Post post { get; set; }

        public int CollectionId { get; set; }
        public Collection collection { get; set; }

    }
}
