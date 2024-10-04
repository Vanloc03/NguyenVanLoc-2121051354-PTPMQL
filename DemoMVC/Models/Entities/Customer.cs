using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models.Entities
{
    public class Customer 
    {
        [Key]
        public string CustomerID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}