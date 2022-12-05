using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class OrganizingArea
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int OrganizerId { get; set; }

    }
}
