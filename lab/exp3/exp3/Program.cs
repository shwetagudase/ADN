// S --

class StudentReport
{
    public void Print()
    {

    }
}

//O---
abstract class Discount
{
    public abstract double GetDiscount();
}

class StudentDiscount : Discount
{
    public override double GetDiscount() => 0.10;
}

class SeniorDiscount : Discount
{
    public override double GetDiscount() => 0.20;
}

////L---

//interface IFlyable
//{
//    void Fly();
//}

//class Sparrow : IFlyable
//{
//    public void Fly() { }
//}

//class Ostrich
//{
//    // No Fly method
//}


class PaymentProcessor
{
    public void ProcessPayment(string paymentType)
    {
        if (paymentType == "CreditCard")
        {
            Console.WriteLine("Processing Credit Card payment");
        }
        else if (paymentType == "UPI")
        {
            Console.WriteLine("Processing UPI payment");
        }
        else
        {
            throw new NotSupportedException("Payment type not supported");
        }
    }
}

class exp3
{
    static void Main(string[] args)
    {
        PaymentProcessor processor = new PaymentProcessor();
        processor.ProcessPayment("Credit Card");
        processor.ProcessPayment("cash");
    }
}