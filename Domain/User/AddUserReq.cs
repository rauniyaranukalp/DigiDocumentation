using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Domain.User
{
    public class AddUserReq
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? username { get; set; }
        public string password { get; set; } = null!;
        public string email { get; set; } = null!;
        public string firstName { get; set; } = null!;
        public string? lastName { get; set; }
    }
}
