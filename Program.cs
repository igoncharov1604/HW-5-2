using System;

class Program
{
    static void Main()
    {
        Tree oak = new Tree("Oak", "A large tree with acorns.", 500);
        Flower rose = new Flower("Rose", "A beautiful flower.", 20);

        oak.Count = 10;
        rose.Count = 15;

        Console.WriteLine($"{oak.Name}: {oak.About}, Price: {oak.Get_Price()}, Count: {oak.Count}");
        Console.WriteLine($"{rose.Name}: {rose.About}, Price: {rose.Get_Price()}, Count: {rose.Count}");
    }
}
