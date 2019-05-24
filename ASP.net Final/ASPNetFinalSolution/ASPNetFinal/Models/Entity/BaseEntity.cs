﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNetFinal.Models.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}