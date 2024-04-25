using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb3_Models_
{
    public class Link
    {
        [Key]
        [JsonIgnore]
        public int LinkID { get; set; }
        public string URL { get; set; }
        [JsonIgnore]
        public int HobbyID { get; set; }
        [JsonIgnore]
        public Hobby Hobby { get; set; } 
    }
}