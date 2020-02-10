using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_1._07
{
    public class Address
    {
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
    }

    public enum ShippingOptions
    { 
        UFS = 1,
        FedEx,
        EMS
    }

    public class Order
    {
        public ShippingOptions ShippingMethod { get; set; }
        public Address Destination { get; set; }
        public Address Origin { get; set; }
    }
}
