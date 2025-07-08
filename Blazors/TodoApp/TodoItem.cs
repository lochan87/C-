using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace TodoApp.Shared
{
    public class TodoItem
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime TemporaryDeadline { get; set; } = DateTime.Today;
        public DateTime ActualDeadline { get; set; } = DateTime.Today;
        public bool IsCompleted { get; set; } = false;
    }
}
