using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }
        [Required(ErrorMessage = "Item Name is must")]
        [MinLength(10, ErrorMessage = "Min characters 10 are needed")]
        [MaxLength(20, ErrorMessage = "Max 20 characteres are allowed")]
        public string name { get; set; }
        [Required(ErrorMessage = "Qty is must")]
        [Range(1, 100, ErrorMessage = "Qty Range is 1- 100")]
        public int? qty_stock { get; set; }
        [Required(ErrorMessage = "Vendor Name is must")]
        public string vendor { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
        [DataType(DataType.Password)]
        [Required]
        [Compare("password", ErrorMessage = "do not match")]
        public string comparepassword { get; set; }
        //
        //[DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Not correct Format")]
        public string EMail { get; set; }
    }

}

