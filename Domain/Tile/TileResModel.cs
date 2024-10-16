using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Domain.Tile
{
    public class TileResModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }
        public string TileName { get; set; }
        [BsonElement("isVisible")]
        public string isVisible { get; set; }
    }
}
