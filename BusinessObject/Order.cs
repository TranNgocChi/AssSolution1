using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class Order
    {
        [Key]
        public Guid OrderId {  get; set; } = Guid.NewGuid();

        [Required]
        public virtual Member? Member { get; set; }

        [Required]  
        public DateTime OrderDate {  get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public decimal Freight { get; set; }

        [Required]
        public Guid MemberId { get; set; }
    }
}
