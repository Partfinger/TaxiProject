using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders.Status
{
    public class ExecuteOrderStatus : OrderStatus
    {
        public Driver Driver { get; set; }

        public override void Handle(Order order)
        {
            order.Status = new DoneOrderStatus();
        }

        public override void Return(Order order)
        {
            order.Status = new WaitOrderStatus();
        }

        public override void Show(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
