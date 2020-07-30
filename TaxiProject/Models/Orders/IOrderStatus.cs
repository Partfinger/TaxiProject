using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiProject.Models.Orders
{
    public interface IOrderStatus
    {
        void Show(Order order);
        /// <summary>
        /// Продвинути статус вище
        /// </summary>
        void Handle(Order order);
        /// <summary>
        /// Опустити статус
        /// </summary>
        void Return(Order order);
        /// <summary>
        /// Выдмынити заявку
        /// </summary>
        void Cancel(Order order);
    }
}
