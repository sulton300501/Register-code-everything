﻿namespace VerifyEmailForgetPassword.Models
{
    public class User
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; } 
        public string? VerificationToken { get; set; }
        public DateTime? VerifiedAt { get; set; }
        public string? PasswordResetToken { get; set; }
        public DateTime? ReseTokenExpires { get; set; }


    }
}
