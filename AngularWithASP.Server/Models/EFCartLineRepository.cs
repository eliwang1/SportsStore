namespace AngularWithASP.Server.Models
{
    public class EFCartLineRepository : ICartLineRepository
    {
        private StoreDbContext context;
        public EFCartLineRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<CartLine> CartLines => context.Cartlines;

        public void SaveCartLine(CartLine cartline)
        {
            //            context.AttachRange(order.Lines.Select(l => l.Product));
            if (cartline.OrderID == 0)
            {
                context.Cartlines.Add(cartline);
            }
            context.SaveChanges();
        }

    }
}
