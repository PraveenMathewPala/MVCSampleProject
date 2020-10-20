using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSampleProject.Models
{
    public class EmployeeLogin
    {
        [Required]
        [Key]
        public int userid
        {
            get;set;
        }
        [Required]
        public string password
        {
            get;set;
        }
        [Required]
        public string confirmPassword
        {
            get;set;
        }
    }
}