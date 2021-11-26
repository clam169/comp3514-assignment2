using System;
using System.ComponentModel.DataAnnotations;

namespace SpeakerLibrary
{
    public class Speaker
    {
        public string SpeakerId { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name ="Mobile Number")]
        [MaxLength(10)]
        [MinLength(10)]
        public string Mobile { get; set; }
        [Required]

        [Display(Name = "Area of Specialization")]
        public string Specialization { get; set; }
        [Required]
        [Display(Name = "City of residence")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Province of residence")]
        public string Province { get; set; }
        [Required]
        public string Employer { get; set; }

    }
}
