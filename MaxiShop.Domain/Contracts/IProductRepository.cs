using MaxiShop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiShop.Domain.Contracts
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetAllProdutDetailsAsync();

        Task<Product> GetProductDetailsAsync(int id);
        Task UpdateAsync(Product product);
    }
}
