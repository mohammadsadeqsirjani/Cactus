using System;
using System.Collections.Generic;

namespace Blade.Test
{
    internal class Person
    {
        public Person()
        {
            CreatedOn = DateTime.UtcNow;
            Addresses = new HashSet<Address>();
        }

        public string Name { set; get; }
        public int Age { set; get; }
        public DateTime Dob { set; get; }
        public string Email { set; get; }
        public string SocialSecurityNo { set; get; }
        public string MobileNo { set; get; }
        public string OfficeNo { set; get; }
        public string PassportNo { set; get; }
        public ICollection<Address> Addresses { set; get; }
        public string BirthPlace { set; get; }
        public string Nationality { set; get; }
        public DateTime CreatedOn { set; get; }

        public override string ToString() =>
            $"Name: {Name}, Age: {Age}, Dob: {Dob}, Email: {Email}, SocialSecurityNo: {SocialSecurityNo}, MobileNo: {MobileNo}, OfficeNo: {OfficeNo}, Address: {Addresses}, PassportNo: {PassportNo}, BirthPlace: {BirthPlace}, Nationality: {Nationality}";
    }
}