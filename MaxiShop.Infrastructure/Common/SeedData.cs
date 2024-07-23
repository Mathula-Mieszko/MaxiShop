using MaxiShop.Domain.Models;
using MaxiShop.Infrastructure.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Infrastructure.Common
{
    public class SeedData
    {
        public static async Task SeedDataAsync(ApplicationDbContext _dbContext)
        {
            if (!_dbContext.Categories.Any())
            {
                await _dbContext.AddRangeAsync(

                    new Category
                    {
                        Name = "Mobile"
                    },
                    new Category
                    {
                        Name = "Laptop"
                    },
                    new Category
                    {
                        Name = "Monitor"
                    },
                    new Category
                    {
                        Name = "Harddisk"
                    }

                );

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
