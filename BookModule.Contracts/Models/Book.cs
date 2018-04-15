namespace BookModule
{
    public class Book
    {
        public int BookId { get; set; }
        public string Instrument { get; set; }
        //public Queue<Order> Buyers { get; set; }
        //public Queue<Order> Sellers { get; set; }
        public MarketStatusEnum MarketStatus { get; set; }

        public bool IsMarketOpen()
        {
            return MarketStatus == MarketStatusEnum.Opened;
        }
    }
}