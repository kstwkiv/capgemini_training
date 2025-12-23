interface OnlinePayment
{
    void pay();
}
class UPIPayment:OnlinePayment
{
    public void pay()
    {
        Console.WriteLine("Payment Via UPI");
    }
}
class CardPayment : OnlinePayment
{
    public void pay()
    {
        Console.WriteLine("Payment via Card");
    }
}