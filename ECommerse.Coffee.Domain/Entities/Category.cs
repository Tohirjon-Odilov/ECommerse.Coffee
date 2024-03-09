﻿using ECommerse.Coffee.Domain.Auditable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerse.Coffee.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
    }
}