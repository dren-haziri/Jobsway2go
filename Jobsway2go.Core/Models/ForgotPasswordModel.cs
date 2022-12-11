using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class ForgotPasswordModel
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
