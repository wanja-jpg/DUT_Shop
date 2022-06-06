using System;
using System.Collections.Generic;
using System.Text;

namespace DUTShopLibrary.Models
{
    public class DescriptionModel
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string Text { get; set; }
    }
}
