﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Ecommerce.Models
{
   public class ProductImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public int ProductID { get; set; }
        public bool IsDeleted { get; set; }

        //Navigation property
        public Product Product { get; set; }

    }
}
