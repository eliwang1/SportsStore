using Microsoft.EntityFrameworkCore;

namespace AngularWithASP.Server.Models {

    public class EFOrderRepository : IOrderRepository {
        private StoreDbContext context;
        private CartLine[] cartlines;

        public EFOrderRepository(StoreDbContext ctx) {
            context = ctx;
        }

        public IQueryable<Order> Orders => context.Orders;

        public void SaveOrder(Order order)
        {
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
                context.SaveChanges();
                var xxx = context.Orders.ToList().Last().OrderID;
                context.Cartlines.Where(c => c.OrderID == 0).ToList().ForEach(c => c.OrderID = xxx);
                context.SaveChanges();
            }
        }
    }
}
