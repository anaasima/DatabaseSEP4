using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DatabaseSEP4.Models
{
    public class Garden
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}