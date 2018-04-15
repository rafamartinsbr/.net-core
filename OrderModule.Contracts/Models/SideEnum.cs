namespace OrderModule.Contracts
{
    public enum SideEnum
    {
        Undefined = 0x0,
        Buy = 0x1,
        Sell = 0x2,
        Cross = Buy + Sell
    }
}