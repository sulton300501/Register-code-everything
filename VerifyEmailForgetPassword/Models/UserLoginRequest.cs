﻿using System.ComponentModel.DataAnnotations;

namespace VerifyEmailForgetPassword.Models
{
    public class UserLoginRequest
    {
        [Required , EmailAddress]
        public string Email { get; set; }=string.Empty;
        [Required]
        public string Password { get; set; }
    }
}
