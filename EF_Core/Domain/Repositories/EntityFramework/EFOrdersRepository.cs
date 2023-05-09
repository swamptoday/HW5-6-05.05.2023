using System.Linq;
using Microsoft.EntityFrameworkCore;
using EF_Core.Domain.Entities;
using EF_Core.Domain.Repositories.Abstract;

namespace EF_Core.Domain.Repositories.EntityFramework
{
    public class EFOrdersRepository : IOrdersRepository
    {
        private readonly AppDbContext context;

        public EFOrdersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Order> GetOrders()
        {
            return context.Orders;
        }

        public Order GetOrderById(int id)
        {
            return context.Orders.FirstOrDefault(x => x.ord_id == id);
        }

        public void SaveOrder(Order entity)
        {
            if (entity.ord_id == default)
            {
                context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            context.Orders.Remove(new Order() { ord_id = id });
            context.SaveChanges();
        }

        public IQueryable<Order> GetOrdersByYear(int year)
        {
            return context.Orders.Where(o => o.ord_datetime.Year == year);

        }

        public string GetOrderAnalys(int id)
        {
            return context.Analysis.FirstOrDefault(x => x.an_id == id).an_name;
        }

    }

}
