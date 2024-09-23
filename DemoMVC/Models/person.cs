using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    public class person {
        [Key]
        public string personId { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}