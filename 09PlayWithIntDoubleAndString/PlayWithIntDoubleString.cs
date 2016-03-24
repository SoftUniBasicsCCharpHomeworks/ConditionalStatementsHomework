using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please, choose a type:\n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter a integer: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(a + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(b + 1.00);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c + "*");
                break;
            default: Console.WriteLine("Choose 1, 2 or 3!"); break;
        }
    }
}
