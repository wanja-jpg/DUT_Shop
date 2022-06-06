using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockQuantity { get; set; }

        public DescriptionModel Description { get; set; }
    }
}
