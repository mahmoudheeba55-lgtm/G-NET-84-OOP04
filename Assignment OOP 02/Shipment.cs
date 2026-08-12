using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Assignment_OOP_02
{
    public abstract class Shipment : ITrackable , IInsurable
    {
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        private DeliveryAdress destination;
         public abstract string GetTrackingStatus();
        public abstract decimal CalculateInsurance();


        public string TrackingCode
        {
            get { return trackingCode; }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }

            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }

            }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }

            }
        }

        public DeliveryAdress Destination
        {
            get { return destination; }
            set { destination = value; }
        }


        public abstract decimal EstimatedCost { get; }
        
          
        


        public Shipment(string trackingCode) : this()
        {
            if (string.IsNullOrWhiteSpace(trackingCode))
            {
                this.trackingCode = "Unknown";
            }
            else
            {
                this.trackingCode = trackingCode;
            }
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            this.destination = new DeliveryAdress("Unknown City", "Unknown Street", 0);
        }
        public Shipment() { }
        public Shipment(string trackingCode, string description, double weight,
                       decimal deliveryFee, DeliveryAdress destination) : this()
        {
            if (!string.IsNullOrWhiteSpace(trackingCode))
            {
                this.trackingCode = trackingCode;
            }
            else
            {
                this.trackingCode = "Unknown";
            }

            if (!string.IsNullOrWhiteSpace(description))
            {
                this.description = description;
            }
            else
            {
                this.description = "Unknown";
            }

            if (weight > 0)
            {
                this.weight = weight;
            }
            else
            {
                this.weight = 1;
                if (deliveryFee > 0)
                {
                    this.deliveryFee = deliveryFee;
                }
                else
                {
                    this.deliveryFee = 50;
                }

                this.destination = destination;
            }
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }

        public abstract void PrintShipment();
        
           
        

        public void weight_update(double NewWeight)
        {

            this.weight = NewWeight;

        }
        public void weight_update(double NewWeight, double PackingWeight)
        {

            this.weight = NewWeight + PackingWeight;

        }
        


    }
}

