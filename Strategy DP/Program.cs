using FactoryCustomer;

class Program
{
    static void Main(string[] args)
    {
        var lead = Factory.Create("Lead");
    }
}