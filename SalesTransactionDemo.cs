using static System.Console;
class SalesTransactionDemo
{
   static void Main()
   {
    SalesTransaction sale1 = new SalesTransaction("Joe", 200.50, .2033);
    SalesTransaction sale2 = new SalesTransaction("Ellen", 15.99);
    SalesTransaction sale3 = sale1 + sale2;
    WriteLine("{0} {1}", sale3.Name, sale3.SalesAmount);
   }
  
}

class SalesTransaction
{
    public double SalesAmount {get; set;}
    public string Name {get; set;}
    public double Commission {get; set;}
    public double RATE {get; set;}
    
    public double getRate()
    {
        return RATE;
    }
    
    public static SalesTransaction operator+(SalesTransaction st1, SalesTransaction st2)
    {
        double newSalesAmount = st1.SalesAmount + st2.SalesAmount;
        return (new SalesTransaction("total", newSalesAmount));
    }
    
    public SalesTransaction(string name, double salesamount, double rate)
    {
        Name = name;
        SalesAmount = salesamount;
        RATE = rate;
        Commission = salesamount * rate;
    }
    
    
     public SalesTransaction(string name, double salesamount)
    {
        Name = name;
        SalesAmount = salesamount;
        RATE = 0;
    }
    
    public SalesTransaction(string name)
    {
        Name = name;
        SalesAmount = 0;
        RATE = 0;
        Commission = 0;
    }
}
