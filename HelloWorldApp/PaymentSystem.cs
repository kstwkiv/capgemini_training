abstract class PaymentSystem
{
    public abstract void pay();

    public void PaymentStarted()
    {
        Console.WriteLine("Payment Started.....");
    }
}
class upiPayment : PaymentSystem
{
    public override void pay()
    {
        Console.WriteLine("UPIpayment done");
    }
}
class cardPayment : PaymentSystem
{
    public override void pay()
    {
        Console.WriteLine("Card payemnt done");
    }
}