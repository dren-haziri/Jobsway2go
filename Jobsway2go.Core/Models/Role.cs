using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class Role:IdentityRole
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
    }
}
