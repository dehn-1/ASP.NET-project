﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

//16
namespace MyProject.BL.Entities
{
    public class User: IdentityUser
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }
        
        public byte[]? ProfilePicture { get; set; }
    }
}
