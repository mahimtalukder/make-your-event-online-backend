using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        public DateTime DeliveryDate { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int ShippingId { get; set; }

    }
}
