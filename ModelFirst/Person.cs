
using System.ComponentModel.DataAnnotations;

namespace ModelFirst
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
