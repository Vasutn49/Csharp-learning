class Program
{
    static void Main()
    {
        Bank b;

        b = new SBI();
        b.Interest();

        b = new HDFC();
        b.Interest();

        b = new ICICI();
        b.Interest();
    }
}