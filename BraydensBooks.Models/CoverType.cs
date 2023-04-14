﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BraydensBooks.Models
{
    public class CoverTypes
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
