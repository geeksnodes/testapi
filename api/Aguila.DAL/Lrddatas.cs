﻿using System;
using System.Collections.Generic;

namespace Aguila.DAL
{
    public partial class Lrddatas
    {
        public Lrddatas()
        {
            LrdattributesLookups = new HashSet<LrdattributesLookups>();
            Lrdcategories = new HashSet<Lrdcategories>();
        }

        public int LrddataId { get; set; }
        public string Lrdtype { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string VideoUrl { get; set; }
        public string ContentLocation { get; set; }

        public virtual ICollection<LrdattributesLookups> LrdattributesLookups { get; set; }
        public virtual ICollection<Lrdcategories> Lrdcategories { get; set; }
    }
}
