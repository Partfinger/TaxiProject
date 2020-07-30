using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using TaxiProject.Models.Orders.Status;

namespace TaxiProject.Models.Orders
{
    public class Order
    {
        public IOrderStatus Status { get; set; }
        public readonly DateTime InitialTime;
        public DateTime LastUpdateTime;
        protected string from, to;
        public string From
        {
            get
            {
                return from;
            }
        }

        public string To
        {
            get
            {
                return to;
            }
        }
        public readonly int ID;
        static int OrdersCount = 0;

        public Order()
        {

        }

        public Order(string _from, string _to)
        {
            from = _from;
            to = _to;
            ID = ++OrdersCount;
            Status = new WaitOrderStatus();
            InitialTime = DateTime.Now;
            LastUpdateTime = DateTime.Now;
        }

        public Order(string _from, string _to, Driver driver)
        {
            from = _from;
            to = _to;
            Status = new WaitOrderStatus();
        }
    }
}
