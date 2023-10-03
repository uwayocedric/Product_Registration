using ProductApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    interface IProductRepository
    {
        Task<bool> AddProductAsync(ProductInfo productInfo);
        Task<bool> UpdateroductAsync(ProductInfo productInfo);
        Task<bool> DeleteProductAsync(int id);
        Task<ProductInfo> GetProductAsync(int id);
        Task<IEnumerable<ProductInfo>> GetProductAsync();
    }
}
