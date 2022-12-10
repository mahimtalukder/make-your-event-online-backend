using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ShippingAddressDTO
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Tag { get; set; }
        public int LocationId { get; set; }
        public int? CustomerId { get; set; }
    }
}
