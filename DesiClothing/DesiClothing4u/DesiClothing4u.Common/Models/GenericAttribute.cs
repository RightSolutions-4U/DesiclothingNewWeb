﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DesiClothing4u.Common.Models
{
    public partial class GenericAttribute
    {
        public int Id { get; set; }
        public string KeyGroup { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public int EntityId { get; set; }
        public int StoreId { get; set; }
        public DateTime? CreatedOrUpdatedDateUtc { get; set; }
    }
}
