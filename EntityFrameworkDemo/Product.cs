using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product
    {
        public int ProductId { get; set; } //Primary key
        public int CategoryId { get; set; }  //Foreign key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }  //birim başına miktarı
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; } //Int16=short
    }
}
