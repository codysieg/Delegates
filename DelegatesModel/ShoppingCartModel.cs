﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatesModel
{
    public class ShoppingCartModel
    {
        public delegate void MentionDiscount(decimal subTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal()
        {
            decimal subTotal = Items.Sum(x => x.Price);

            if (subTotal > 100)
            {
                return subTotal * 0.80M;
            }
            else if (subTotal > 50)
            {
                return subTotal * 0.85M;
            }
            else if (subTotal > 10)
            {
                return subTotal * 0.90M;
            }

            return subTotal;
        }
    }
}
