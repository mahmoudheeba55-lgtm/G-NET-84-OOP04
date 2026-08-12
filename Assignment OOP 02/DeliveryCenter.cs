using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_OOP_02
{
    public class DeliveryCenter
    {
        public Shipment[] shipments;
        private const int MaxShipments = 20;

        public Driver driver;
        public string CenterName { get; set; }

        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            shipments = new Shipment[MaxShipments];
        }
        public DeliveryCenter()
        {
            shipments = new Shipment[MaxShipments];
        }
        public Shipment this[int index]
        {
            get
            {
                if (index >= 0 && index < MaxShipments)
                {
                    return shipments[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < MaxShipments)
                {
                    shipments[index] = value;
                }
            }
        }
        public Shipment this[string trackingCode]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(trackingCode))
                {
                    return default;
                }

                for (int i = 0; i < MaxShipments; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }

                }
                return default;
            }
        }


        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < MaxShipments; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }

            }
            return false;
        }

        public bool RemoveShipment(string trackingCode)
        {
            for (int i = 0; i < MaxShipments; i++)
            {
                if (shipments[i] != null &&
                    shipments[i].TrackingCode == trackingCode)
                {
                    shipments[i] = null;
                    return true;
                }
            }

            return false;
        }
        public void PrintTrackingStatus()
        {
            for (int i = 0; i < 3; i++)
            {
                ITrackable t = shipments[i];
                Console.WriteLine(shipments[i].GetTrackingStatus ());

            }
        }
            public void PrintIInsurableStatuses()
        {
            for (int i = 0; i < 3; i++)
            {
                IInsurable I = shipments[i];
                Console.WriteLine(shipments[i].CalculateInsurance());
            }
        }

    }
}

    