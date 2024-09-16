using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models.Entities
{
    [Table("NguyenVanLoc")]
    public class NguyenVanLoc 
    {
        [Key]
        public string NguyenVanLocID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }
}

