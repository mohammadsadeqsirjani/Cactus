using System;

namespace Blade.Test
{
    internal class Product
    {
        public string Name { set; get; }
        public DateTime ExpiryDate { set; get; }
        public decimal Price { set; get; }
        public string[] Sizes { set; get; }

        public override string ToString() =>
            $"Name: {Name}, ExpiryDate: {ExpiryDate}, Price: {Price}, Sizes: [{string.Join(",", Sizes)}]";
    }
}