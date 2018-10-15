﻿using System.ComponentModel.DataAnnotations;

namespace Aguila.Models.AccountModel
{
    public class AddExternalLoginBindingModel
    {
        [Required]
        [Display(Name = "External access token")]
        public string ExternalAccessToken { get; set; }
    }
}
