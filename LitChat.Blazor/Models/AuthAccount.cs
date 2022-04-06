﻿using System.ComponentModel.DataAnnotations;

namespace LitChat.Blazor.Models
{
    public class AuthAccount
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
