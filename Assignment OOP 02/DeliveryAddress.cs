using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{
    public struct DeliveryAdress
    {
        public string City;
        public string Street;
        public int BuildingNumber;


        public DeliveryAdress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }


        public string GetFullAddress()
        {
            return $"{BuildingNumber} {Street}, {City}";
        }
    }
}
