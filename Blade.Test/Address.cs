using System;

namespace Blade.Test
{
    internal class Address
    {
        public Address()
        {
            CreatedOn = DateTime.UtcNow;
            Active = true;
        }

        public string Street1 { set; get; }
        public string Street2 { set; get; }
        public string Street3 { set; get; }
        public string City { set; get; }
        public string Country { set; get; }
        public DateTime CreatedOn { set; get; }
        public bool Active { set; get; }

        public override string ToString()
        {
            return
                $"Active: {Active}, City: {City}, Country: {Country}, CreatedOn: {CreatedOn}, Street1: {Street1}, Street2: {Street2}, Street3: {Street3}";
        }
    }
}