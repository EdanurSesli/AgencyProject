﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunMedyaAkademiAgency.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public String CategoryName { get; set; }
        public List<Project> Projects { get; set; }
    }
}