using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{
    public class StanderdShipment
    {
        public class StandardShipment : Shipment
        {
            public StandardShipment(string trackingCode,

                                    string description, double weight, decimal deliveryFee, DeliveryAdress destination)

                : base(trackingCode, description, weight, deliveryFee, destination)
            {
              
            }

            public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);

            public override void PrintShipment()
            {
                Console.WriteLine($"Tracking Code: {TrackingCode}");
                Console.WriteLine($"Description: {Description}");
                Console.WriteLine($"Weight: {Weight} KG");
                Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
                Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
                Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            }
            public override string GetTrackingStatus()
            {
                return $"Shipment {TrackingCode} is Ready";
            }
        public override  decimal CalculateInsurance()
            {
                decimal x = 5m / 100m;
                return EstimatedCost * x;
            }
            
        }
    }
}
