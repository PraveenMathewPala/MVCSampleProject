using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCSampleProject.Models
{
    public class Employee
    {
        [Required]
        [Key]
        public int Empid
        {
            get; set;
        }
        [Required]
        public string Empname
        {
            get; set;
        }
        [Required]
        public string DeptName
        {
            get; set;
        }
        [Required]
        public long PhoneNo
        {
            get; set;
        }
        [Required]
        public string password
        {
            get; set;
        }
        [Required]
        public string confirmPassword
        {
            get; set;
        }
    }
}