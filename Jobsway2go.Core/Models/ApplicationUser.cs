using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobsway2go.Core.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
        public int PhoneNumber { get; set; }
        public string ImagePath { get; set; }
        public string  Certificates { get; set; }

        /*public List<Collection> Collections {get;set;} 
         * public List<Language> Languages { get; set; }
        public List<Project> Projects { get; set; }*/

        public string  Badges { get; set; }
        public string Courses { get; set; }
        public string References { get; set; }
        public Boolean IsPremium { get; set; }
        public bool isActive { get; set; }

    }
}
