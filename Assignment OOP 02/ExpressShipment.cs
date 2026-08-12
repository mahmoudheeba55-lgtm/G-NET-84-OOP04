using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{


    public class ExpressShipment : Shipment
    {
        private decimal extraFee;
        public ExpressShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAdress destination, decimal extraFee)
                : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.extraFee = extraFee;
        }
        public decimal ExtraFee
        {
            get => extraFee;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("extraFee can not be 0 enter positive number");
                }
                else
                {
                    extraFee = value;
                }
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($" Description   : {Description}");
            Console.WriteLine($" Weight        : {Weight} kg");
            Console.WriteLine($" Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($" Destination   : {Destination.GetFullAddress()}");
            Console.WriteLine($"Extrafee : {ExtraFee}");
            Console.WriteLine($"Estimated cost : {EstimatedCost}");
            Console.WriteLine("----------------------------------");
        }
        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is out of delivery";
        }
        public override decimal CalculateInsurance()
        {
            decimal x = 8m / 100m;
            return EstimatedCost * x;
        }

    }


}




