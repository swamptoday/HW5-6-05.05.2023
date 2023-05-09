using System.Linq;
using EF_Core.Domain.Entities;

namespace EF_Core.Domain.Repositories.Abstract
{
    public interface IOrdersRepository
    {
        public IQueryable<Order> GetOrders();

        public Order GetOrderById(int id);

        public void SaveOrder(Order entity);

        public void DeleteOrder(int id);
        public IQueryable<Order> GetOrdersByYear(int year);
    }
}
