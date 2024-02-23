using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Genspil
{

    public static void Main()
    {
        PrintPerson();
        PrintPerson("Lebbe ebbe", 18);
        PrintPerson(age: 18, name: "Small dick B");
        PrintPlus(2, 5);
        PrintPlus(6);
        PrintMathing(3, 6);
        PrintWelcomeHaveANiceDay();


    }

    public static void PrintPerson(string name = "Big dick jones", int age = 18)
    {


        Console.WriteLine($"{name} er {age} år gammel");

    }

    public static void PrintPlus(int x, int y = 27)
    {
        Console.WriteLine($"{x} + {y} = {Plus(x, y)}");
    }
    public static int Plus(int x, int y)
    {
        return x + y;

    }
    public static void PrintMathing(int x, int y)
    {


        Console.WriteLine($"{x} + {y} = {Mathing(x, y)}");

    }
    public static int Mathing(int x, int y)
    {
        int res;
        if (true)

        {
            res = x + y;
        }
        // else
        // {

        //     res = x - y;
        // }

        return res;
    }
    public static void Welcome(string name)
    {

        Console.WriteLine("Welcome " + name + " !");
    }
    public static void HaveANiceDay()
    {

        Console.WriteLine("Have A Nice Day");
    }
    public static int Sum(int num1, int num2)
    {
        int total;
        total = num1 - num2;
        return total;
    }
    public static void PrintWelcomeHaveANiceDay()
    {

        Console.Write("\n\n");
        Console.Write("------------------------------------------------\n\n");

        string str1;
        string str2;

        Console.WriteLine("ÆLDSTE FØRST");

        Console.Write("Skriv navn: ");
#pragma warning disable CS8600 
        str1 = Console.ReadLine();
#pragma warning restore CS8600 

        Console.Write(".......\n");

        Console.Write("Skriv navn: ");
#pragma warning disable CS8600 
        str2 = Console.ReadLine();
#pragma warning restore CS8600 

        Console.Write(".......\n");

        Console.Write("Hvor gammle er i\n");

        Console.Write(".......\n");
#pragma warning disable CS8604 
        Welcome(str1);
#pragma warning restore CS8604 
        Console.Write("\nHvor gammel er du?: ");
        int num1 = Convert.ToInt32(Console.ReadLine());




        Console.Write(".......\n");

#pragma warning disable CS8604 
        Welcome(str2);
#pragma warning restore CS8604
        Console.WriteLine("\nHvor gammel er du?: ");
        int num2 = Convert.ToInt32(Console.ReadLine());


        if (Sum(num1, num2) >= 1)
        {
            Console.WriteLine("\n HAN ER UNDERAGE!: {0} \n", Sum(num1, num2));
        }
        else
        {
            Console.WriteLine("\n Han er ikke underage du er good!: {0} \n", Sum(num1, num2));
        }

        HaveANiceDay();
        Console.WriteLine("\n");
    }

}


