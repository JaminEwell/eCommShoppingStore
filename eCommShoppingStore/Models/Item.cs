﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommShoppingStore.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public int CategoryId { get; set; }
        public int ProducerId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ItemArtUrl { get; set; }
        public Category Category { get; set; }
        public Producer Producer { get; set; }
    }
}