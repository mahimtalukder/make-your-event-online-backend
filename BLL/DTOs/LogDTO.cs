﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class LogDTO
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public DateTime CreateTime { get; set; }
        public int? UserId { get; set; }
    }
}
