﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Msp.Entity.Entities
{
    [Table("ProductMark")]
    public class ProductMark
    {
        [Key]
        public int RecId { get; set; }
        public string Mark { get; set; }
        public string Remark { get; set; }
    }
}
