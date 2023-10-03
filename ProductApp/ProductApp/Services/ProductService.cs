﻿using ProductApp.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Services
{
    public class ProductService : IProductRepository
    {
        public SQLiteAsyncConnection _database;

        public ProductService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<ProductInfo>().Wait();
        }

        public async Task<bool> AddProductAsync(ProductInfo productInfo)
        {
            if (productInfo.ProductId > 0)
            {
                await _database.UpdateAsync(productInfo);
            }
            else
            {
                await _database.InsertAsync(productInfo);
                Console.WriteLine("The Saved Instance - Product ID" + productInfo.ProductId);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            await _database.DeleteAsync<ProductInfo>(id);

            return await Task.FromResult(true);
        }

        public async Task<ProductInfo> GetProductAsync(int id)
        {
            return await _database.Table<ProductInfo>().Where(p => p.ProductId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductInfo>> GetProductAsync()
        {
            return await Task.FromResult(await _database.Table<ProductInfo>().ToListAsync());
        }

        public Task<bool> UpdateroductAsync(ProductInfo productInfo)
        {
            throw new NotImplementedException();
        }
    }
}
