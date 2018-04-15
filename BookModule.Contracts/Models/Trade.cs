using System;

namespace BookModule
{
    public class Trade
    {
        public int TradeId { get; set; }
        public string Instrument { get; set; }
        public decimal Size { get; set; }
        public decimal Price { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}