using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Division { get; set; }
        public string District { get; set; }
        public string Thana { get; set; }

    }
}
