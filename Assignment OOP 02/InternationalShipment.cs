using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{
    public class InternationalShipment : Shipment
    {

        public InternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee,
              DeliveryAdress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get => destinationCountry;
            set
            {
                if (value != null && !string.IsNullOrWhiteSpace(value))
                {
                    destinationCountry = value;
                }
                else
                {
                    Console.WriteLine("Enter Valid DestinationCountry");
                }
            }
        }

        public decimal CustomsFee
        {
            get => customsFee;
            set
            {
                if (value >= 0)
                {
                    customsFee = value;
                }
                else
                {
                    Console.WriteLine("Enter positive value");
                }
            }
        }

        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5) + CustomsFee;

        public virtual void GenerateCustomsReport()
        {
            Console.WriteLine("Customs report for Priority International shipment.");
        }
        public override void PrintShipment()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($" Description   : {Description}");
            Console.WriteLine($" Weight        : {Weight} kg");
            Console.WriteLine($" Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($" Destination Country   : {DestinationCountry}");
            Console.WriteLine($"CustomsFee:{customsFee}");
            Console.WriteLine($"Estimated cost : {EstimatedCost}");
            Console.WriteLine("----------------------------------");
        }
        public override string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered";
        }
        public override decimal CalculateInsurance()
        {
            decimal x = 12m / 100m;
            return EstimatedCost * x;
        }
    }
}
