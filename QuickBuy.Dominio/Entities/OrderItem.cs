namespace QuickBuy.Dominio.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }
    }
}
