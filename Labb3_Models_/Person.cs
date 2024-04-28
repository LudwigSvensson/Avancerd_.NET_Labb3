using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Labb3_Models_
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        [JsonIgnore]
        public ICollection<Hobby> Hobbies { get; set; } = new List<Hobby>();
        [JsonIgnore]
        public ICollection<Link> Links { get; set; } = new List<Link>();
    }
}
