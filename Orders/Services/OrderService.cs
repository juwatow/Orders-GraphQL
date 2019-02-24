using Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private IList<Order> _orders;

        public OrderService()
        {
            _orders = new List<Order>
            {
                new Order(1, "Nike-Cortez", "Blue Nike-Cortez size 45", DateTime.Now.AddDays(-2), 5),
                new Order(2, "Adidas-Teeshort", "Grey Adidas-Teeshort size XL", DateTime.Now.AddDays(-5), 2)
            };
        }

        public Task<Order> GetOrderByIdAsync(int id)
        {
            return Task.FromResult(_orders.Single(o => Equals(o.Id, id)));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }

    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(int id);
        Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
