using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ResumeSystem_Onsite_08_03_2017.Models
{
    public class Applicants
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name is a must!")]
        [Display(Name ="Last name")]      
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}