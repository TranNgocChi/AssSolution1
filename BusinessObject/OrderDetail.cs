using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class OrderDetail
    {
        [Key]
        public Guid OrderDetailId { get; set; } = Guid.NewGuid();   

        [Required]
        public virtual Order? Order {  get; set; }

        [Required]
        public virtual Product? Product { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        public decimal? UnitPrice { get; set; }

        public int? Quantity { get; set; }
        public float? Discount { get; set;}
    }
}
