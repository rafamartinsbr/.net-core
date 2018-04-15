namespace OrderModule.Contracts
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int BrokerId { get; set; }
        public SideEnum Side { get; set; }
        public string Instrument { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
    }
}