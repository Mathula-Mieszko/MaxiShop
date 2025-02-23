﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.InputModels
{
    public class Register
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty ;

        [Required]
        public string Email { get; set; } = string.Empty ;

        [Required]
        public string Password {  get; set; } = string.Empty ;
        
    }
}
