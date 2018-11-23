﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class SongCategory
    {
        public int SongId { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Song Song { get; set; }
    }

}
