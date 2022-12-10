﻿using Jobsway2go.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Interfaces
{
    public interface IUserService
    {
         bool SignIn { get; set; }
         bool SignOut { get; set; }

        bool Register(ApplicationUser user);
        bool  EmailVerification { get;set; }
        bool  EmailConfirmed { get; set; }

        bool  EditProfile { get; set; }
        bool  VerifyUser { get; set; } 
    }
}
