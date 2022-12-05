using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double PricePerUnit { get; set; }
        [Required]
        public DateTime TentativeDeliveryDate { get; set; }
        [Required]
        public int ThumbnailId { get; set; }
        [Required]
        public int Availability { get; set; }
        [Required]
        public int OrganizerId { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
