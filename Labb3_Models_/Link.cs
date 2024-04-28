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
        public ICollection<Hobby> Hobbies { get; set; } = new List<Hobby>();
        [JsonIgnore]
        public ICollection<Person> Persons { get; set;} = new List<Person>();
    }
}