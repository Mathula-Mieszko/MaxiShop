using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Application.DTO.Product
{
    public class CreateProductDto
    {
        [Required]
        public int CategoryId { get; set; }
        [Required]

        public int BrandId { get; set; }
        [Required]

        public string Name { get; set; } = string.Empty;
        [Required]

        public string Description { get; set; } = string.Empty;
        [Required]

        public double Price { get; set; }

    }
}
