using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSemesterProject
{
    class Customer
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public Customer() {  }

        public Customer(string fullname, string address, string addressLine2, 
                        string city, string state, string zip)
        {
            Fullname = fullname;
            Address = address;
            AddressLine2 = addressLine2;
            City = city;
            State = state;
            Zip = zip;
        }

        //constructor in case second address line is empty
        public Customer(string fullname, string address, string city, string state, string zip)
        {
            Fullname = fullname;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            return Fullname + " " + Address + " " + AddressLine2 + " " + City + " " + State + " "
                + Zip;
        }

        public string ToStringFormatted()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Fullname + Environment.NewLine);
            sb.Append(Address + Environment.NewLine);
            sb.Append(AddressLine2 + Environment.NewLine);
            sb.Append(City + " " + State + " " + Zip);
            return sb.ToString();
        }
    }
}
