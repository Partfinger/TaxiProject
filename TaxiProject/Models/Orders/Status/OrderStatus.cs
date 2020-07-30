using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders.Status
{
    public abstract class OrderStatus : IOrderStatus
    {
        public void Cancel(Order order)
        {
            order.Status = new CanceledOrderStatus();
            UpdateOrderTime(order);
        }

        protected void UpdateOrderTime(Order order)
        {
            order.LastUpdateTime = DateTime.Now;
        }

        public abstract void Handle(Order order);
        public abstract void Return(Order order);
        public abstract void Show(Order order);
    }
}
