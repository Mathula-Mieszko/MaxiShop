﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.DTO.Brand
{
    public class CreateBrandDto
    {
        public string Name { get; set; } = string.Empty;

        public int publishedYear { get; set; }
    }

    public class CreateBrandDtoValidator:AbstractValidator<CreateBrandDto>
    {
        public CreateBrandDtoValidator()
        {
            RuleFor(x=>x.Name).NotNull().NotEmpty();
            RuleFor(x => x.publishedYear).InclusiveBetween(1920, DateTime.UtcNow.Year);
        }
    }
}
