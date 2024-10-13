using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Domain.User
{
    public class AddUserReq
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }
        public string firstName { get; set; } = null!;
        public string lastName { get; set; } = null!;
        public string password { get; set; } = null!;
        public string email { get; set; } = null!;
        public string? username { get; set; } 
        public string role { get; set; } = "user";
        public bool isActive { get; set; } = true;
    }
}
