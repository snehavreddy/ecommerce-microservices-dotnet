using MongoDB.Driver;
using ProductService.Models;
using ProductService.Services.Interfaces;

namespace ProductService.Services
{
    public class ProductServiceImpl : IProductService
    {
        private readonly IMongoCollection<Product> _products;

        public ProductServiceImpl(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>("MongoDB:ConnectionString"));
            var database = client.GetDatabase(config.GetValue<string>("MongoDB:DatabaseName"));
            _products = database.GetCollection<Product>("products");
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _products.Find(_ => true).ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(string id)
        {
            return await _products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _products.InsertOneAsync(product);
            return product;
        }
    }
}
