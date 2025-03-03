﻿using System.ComponentModel.DataAnnotations;

namespace UsersApp.ViewModels
{
    public class ChangePasswordViewModel
    {


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Password is required")]
        [StringLength(40, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]

        [Compare("ConfirmNewPassword", ErrorMessage = "Password does not match.")]
        public string NewPassword { get; set; }


        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
