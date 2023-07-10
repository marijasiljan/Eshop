﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EShopAdminApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }

        [EnumDataType(typeof(Genre))]
        public Genre ProductGenre { get; set; }
        public string ProductImage { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public int ProductRating { get; set; }
    }
}
