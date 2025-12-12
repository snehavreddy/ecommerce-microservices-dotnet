using AuthService.Models;
using AuthService.Services.Interface;
using MongoDB.Driver;

namespace AuthService.Services
{
    public class UserService : IUserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>("MongoDB:ConnectionString"));
            var database = client.GetDatabase(config.GetValue<string>("MongoDB:DatabaseName"));
            _users = database.GetCollection<User>("users");
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _users.Find(u => u.Email == email).FirstOrDefaultAsync();
        }

        public async Task<User> CreateAsync(User user)
        {
            await _users.InsertOneAsync(user);
            return user;
        }
    }
}
