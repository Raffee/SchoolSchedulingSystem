using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace SchoolSchedulingSystem.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    //Changes from this page
    //https://mycodelog.com/2015/08/18/asp-net-vnext-identity-3-0-beta6-in-mvc-6-beta6-spa-using-integer-keys-instead-of-strings/
    public class ApplicationUser : IdentityUser<int>
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public School School { get; set; }

        public int SchoolID { get; set; }
    }

    public class ApplicationRole:IdentityRole<int>
    {

    }
}
