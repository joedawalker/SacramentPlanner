using System;
using Newtonsoft.Json;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SacramentPlanner.Models
{
    public class Agenda
    {
        [BsonId]
        [BsonRepresentation( BsonType.ObjectId )]
        [BsonElement("_id")]
        [JsonProperty( "agenda_id" )]
        public string AgendaId { get; set; }

        [BsonElement( "date" )]
        [JsonProperty( "date" )]
        public DateTime Date { get; set; }

        [BsonElement( "presiding_authority" )]
        [JsonProperty( "presiding_authority" )]
        public string PresidingAuthority { get; set; }

        [BsonElement( "conducting" )]
        [JsonProperty( "conducting" )]
        public string Conducting { get; set; }

        [BsonElement( "opening_prayer" )]
        [JsonProperty( "opening_prayer" )]
        public string OpeningPrayer { get; set; }

        [BsonElement( "closing_prayer" )]
        [JsonProperty( "closing_prayer" )]
        public string ClosingPrayer { get; set; }

        [BsonElement( "speakers" )]
        [JsonProperty( "speakers" )]
        public string[] SpeakingAssignments { get; set; }

        [BsonElement( "opening_hymn" )]
        [JsonProperty( "opening_hymn" )]
        public int OpeningHymn { get; set; }

        [BsonElement( "sacrament_hymn" )]
        [JsonProperty( "sacrament_hymn" )]
        public int SactamentHymn { get; set; }

        [BsonElement( "intermediate_hymn" )]
        [JsonProperty( "intermediate_hymn" )]
        public int? IntermediateHymn { get; set; }

        [BsonElement( "closing_hymn" )]
        [JsonProperty( "closing_hymn" )]
        public int ClosingHymn { get; set; }
    }
}
