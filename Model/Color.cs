﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Color :BaseEntity
    {
       public string Name { get; set; }   
       public string? HEX { get; set; }   
       public string? RGB { get; set; }   
    }
}
