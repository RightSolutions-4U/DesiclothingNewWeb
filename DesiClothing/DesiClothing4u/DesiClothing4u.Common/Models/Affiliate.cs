﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DesiClothing4u.Common.Models
{
    public partial class Affiliate
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string AdminComment { get; set; }
        public string FriendlyUrlName { get; set; }
        public bool Deleted { get; set; }
        public bool Active { get; set; }

        public virtual Address Address { get; set; }
    }
}
