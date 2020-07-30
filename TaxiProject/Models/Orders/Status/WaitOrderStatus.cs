using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders.Status
{
    public class WaitOrderStatus : OrderStatus
    {
        public override void Handle(Order order)
        {
            order.Status = new ExecuteOrderStatus();
        }

        public override void Return(Order order)
        {
            Cancel(order);
        }

        public override void Show(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
