using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CourseApplication.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }

        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
    }
}