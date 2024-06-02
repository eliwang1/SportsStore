namespace AngularWithASP.Server.Models
{
    public class CartLine
    {
        public int CartlineID { get; set; }

        public long ProductID { get; set; }

        public int Quantity { get; set; }

        public int OrderID { get; set; }

    }
}
