using static Assignment_OOP_02.StanderdShipment;

namespace Assignment_OOP_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Theoretical Questions
            //Q1:
            Console.WriteLine("a.Abstraction: Hiding complixity details with showing princible details ");
            Console.WriteLine("b. reduse complixity & promote filixabilty ");
            // Q2:
            Console.WriteLine("a. abstract contain fields , methods ,allow single inhiritance but interface contain contract(signture methods) , doesn't contain fields & allow multiple implemention ) " +
                "b. if there multiple implementation i use interface " +
                "c.no,yes");
            #endregion
            #region  Practical

            Driver driver = new Driver(123, "Ali", 0125565698);
            DeliveryCenter center = new DeliveryCenter("Amazon");
            DeliveryAdress deliveryAddress = new DeliveryAdress("elmahala", "elshone", 6);
            center.driver = driver;
            StandardShipment standardShipment = new StandardShipment("sh001", "laptob", 3, 80, deliveryAddress);
            Console.WriteLine("Enter Extra Fee:");
            decimal ExtraFee = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Extra Fee: {ExtraFee}");
            ExpressShipment expressShipment = new ExpressShipment("sh002", "mobile ", 2, 60, deliveryAddress, ExtraFee);
            Console.WriteLine("Enter your Destination country:");
            string country = Console.ReadLine();
            InternationalShipment international = new InternationalShipment("sh003", "television", 8, 120, deliveryAddress, country, 300);
            ITrackable[] trackables = new ITrackable[] { standardShipment, expressShipment, international };
            ITrackable[] iinsurable = new ITrackable[] { standardShipment, expressShipment, international };

            center.AddShipment(standardShipment);
            center.AddShipment(expressShipment);
            center.AddShipment(international);

            Shipment[] printTypeshipment = new Shipment[] { standardShipment, expressShipment, international };
            for (int i = 0; i < 3; i++)
            {
                printTypeshipment[i].PrintShipment();
            }
            Console.WriteLine("==========================================");

            Console.WriteLine("Tracking Status");


            string print = standardShipment.GetTrackingStatus();
            Console.WriteLine(print);
            string show = expressShipment.GetTrackingStatus();
            Console.WriteLine(show);
            string _show = international.GetTrackingStatus();
            Console.WriteLine(_show);

            Console.WriteLine("========================================");

            Console.WriteLine("Insurance");
            decimal x = standardShipment.CalculateInsurance();
            Console.WriteLine(x);
            decimal y = expressShipment.CalculateInsurance();
            Console.WriteLine(y);
            decimal z = international.CalculateInsurance();
            Console.WriteLine(z);

            Console.WriteLine("========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion
        }

    }
    }








