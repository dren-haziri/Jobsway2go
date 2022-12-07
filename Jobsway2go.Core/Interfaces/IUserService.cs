using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IUserService
    {
        public Boolean SignIn { get; set; }
        public Boolean SignOut { get; set; }

        public Boolean Register { get; set; }
        public Boolean EmailVerification { get;set; }
        public Boolean EmailConfirmed { get; set; }

        public Boolean EditProfile { get; set; }
        public Boolean VerifyUser { get; set; } 
    }
}
