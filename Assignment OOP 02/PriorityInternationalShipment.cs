using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{


    public class priorityInternationalShipment : InternationalShipment
    {
        public priorityInternationalShipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAdress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination, destinationCountry, customsFee)
        {

        }

        public sealed override void GenerateCustomsReport()
        {
            Console.WriteLine("Customs report for Priority International shipment.");
        }
    }








}
