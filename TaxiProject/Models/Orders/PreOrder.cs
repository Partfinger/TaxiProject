using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders
{
    public class PreOrder : Order
    {
        public string Name, EMail, Number;
        public DateTime DestinationTime;

        public PreOrder(string name, string email, string number, string from, string to, DateTime date) : base(from, to)
        {
            Name = name;
            EMail = email;
            Number = number;
            DestinationTime = date;
        }
    }
}
