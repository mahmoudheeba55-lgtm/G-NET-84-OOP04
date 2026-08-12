using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{
    public class Delivery_Report
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($"{shipment.GetTrackingStatus}");

        }
        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($"{shipment.CalculateInsurance}");
        }

    }
}
