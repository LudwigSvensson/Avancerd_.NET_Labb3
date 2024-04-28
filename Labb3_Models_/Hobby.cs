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
        public ICollection<Person> Persons { get; set; } = new List<Person>();
      
        public ICollection<Link> Links { get; set; }  = new List<Link>();
    }
}