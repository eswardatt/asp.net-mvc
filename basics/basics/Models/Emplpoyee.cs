﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace basics.Models
{
    [Table("tblEmployee")]
    public class Emplpoyee
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        
    }
}