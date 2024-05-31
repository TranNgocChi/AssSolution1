using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Product
    {
        public Guid ProductId { get; set; }= Guid.NewGuid();

        [Required]
        [StringLength(40, ErrorMessage = "Name Product <= 40")]
        public string? ProductName {  get; set; }

        [Required]
        public int? CategoryId { get; set; }    

        [Required]
        [StringLength(40, ErrorMessage = "Name Product <= 40")]
        public string? Weight { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }

        [Required]
        public int UnitsInStock { get; set; }

        



    }
}
