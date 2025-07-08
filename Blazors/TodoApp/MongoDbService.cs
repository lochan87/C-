using MongoDB.Driver;
using TodoApp.Shared;
using Microsoft.Extensions.Options;

namespace TodoApp.Server.Services
{
    public class MongoDbService
    {
        private readonly IMongoCollection<TodoItem> _todoCollection;

        public MongoDbService(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            var database = client.GetDatabase("TodoDb");
            _todoCollection = database.GetCollection<TodoItem>("Todos");
        }

        public async Task<List<TodoItem>> GetAsync() =>
            await _todoCollection.Find(_ => true).ToListAsync();

        public async Task<TodoItem?> GetByIdAsync(string id) =>
            await _todoCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(TodoItem item) =>
            await _todoCollection.InsertOneAsync(item);

        public async Task UpdateAsync(string id, TodoItem item) =>
            await _todoCollection.ReplaceOneAsync(x => x.Id == id, item);

        public async Task DeleteAsync(string id) =>
            await _todoCollection.DeleteOneAsync(x => x.Id == id);
    }
}
