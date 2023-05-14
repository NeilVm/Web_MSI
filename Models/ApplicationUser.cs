using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Web_MSI.Models;


namespace Web_MSI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName  { get; set; }
        public string LastName { get; set; }
    }
}