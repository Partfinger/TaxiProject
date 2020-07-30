using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders.Status
{
    public class CanceledOrderStatus : OrderStatus
    {
        public User abrogator;

        public override void Handle(Order order)
        {
            throw new NotImplementedException();
        }

        public override void Return(Order order)
        {
            throw new NotImplementedException();
        }

        public override void Show(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
