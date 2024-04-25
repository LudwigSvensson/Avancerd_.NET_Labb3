using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb3_Models_
{
    public class Hobby
    {
        [Key]
        public int HobbyID { get; set; }
        public string HobbyTitle { get; set; }
        public string HobbyDescription { get; set; }
        [JsonIgnore]
        public int PersonID { get; set; }
        [JsonIgnore]
        public Person Person { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}