﻿using System.ComponentModel.DataAnnotations;

namespace Bit.Core.Models.Api
{
    public class PasswordHintRequestModel
    {
        [Required]
        [EmailAddress]
        [StringLength(50)]
        public string Email { get; set; }
    }
}
