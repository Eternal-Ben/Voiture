﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoituresEF
{
    [Table("Segment")]
    public class Segment
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }
}
