using Factory_DP;

class Program
{
    static void Main(string[] args)
    {
        var factory = new Factory();
        var emp = factory.Create("Programmer");
    }
}