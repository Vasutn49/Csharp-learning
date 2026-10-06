using polymorphism_ex1;
using System;
class Program
{
    public static void Main()
    {
        bank b1 = new bank(12345678901, "hdfc1617", "Pooja", 7358725667, 1000, 1456);
        bank b2 = new bank(39564901569, "hdfc1617", "Abi", 6798309561, 1000, 4876);

        b1.deposit("Pooja", 7358725667, 10000);

    }
}

