using MongoForm.Models;
using MongoDB.Driver;

namespace MongoForm.Services
{
    public class MongoService
    {
        private readonly IMongoCollection<UserSubmission> _collection;

        public MongoService(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDB:ConnectionString"]);
            var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
            _collection = database.GetCollection<UserSubmission>("FormsC");
        }

        public async Task InsertSubmission(UserSubmission submission)
        {
            await _collection.InsertOneAsync(submission);
        }
    }
}
