using System;

class Program
{
    static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.Sound();

        animal = new Cat();
        animal.Sound();

        Console.ReadLine();
    }
}


