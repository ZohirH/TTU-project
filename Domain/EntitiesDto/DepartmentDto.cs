﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntitiesDto
{
    public  class DepartmentDto
    {     
        public string? Title { get; set; }
        public string? Description { get; set; }
        public bool? Enabled { get; set; }
    }
}
