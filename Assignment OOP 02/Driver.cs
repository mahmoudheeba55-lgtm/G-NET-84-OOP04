using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Channels;

namespace Assignment_OOP_02
{
    public class Driver
    {
        private int id;
        private string fullname;
        private int phonenumber;

        public Driver(int id, string fullname, int phonenumber)
        {
            this.id = id;
            this.fullname = fullname;
            this.phonenumber = phonenumber;
        }


        public int Id
        {
            get => id;
            set
            {
                if (value >= 0) { id = value; }

            }
        }
        public string FullName
        {
            get => fullname;
            set
            {
                if (value != null) { fullname = value; }

            }
        }
        public int PhoneNumber
        {
            get => phonenumber;
            set
            {
                if (value >= 0) { phonenumber = value; }
               
            }

        }
        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FullName}, Phone: {PhoneNumber}");
        }


    }


}