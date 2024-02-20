public class Method{

public static void Main(){
    HelloWorld();
    EgenKode();
    Gambling();
         } 

public static void HelloWorld(){
    Console.WriteLine("Hello World");
    } 

    static void EgenKode()
    {

        

        int i = 0;

        do
        {
    i = new Random().Next(-10000, 1000000000);
  Console.WriteLine(i);

        }
        while (i != new Random().Next(-10000, 1000000000));


Console.Write("\nKoden til Mr.Fisters telefon er : {0}\n",i);   
  
Console.Write("Skriv Mr. Fisters telefon nummer :");
i = Convert.ToInt32(Console.ReadLine());


Console.Write("Mr.Fister er dum nu har vi pia´s telefon nummer");
    }
    static int playerMoney = 1000; // Starting amount of fake money

    static void Gambling()
    {
        Console.WriteLine("Welcome to the Slot Machine Game!");
        Console.WriteLine($"You currently have {playerMoney} €.");

        while (playerMoney > 0)
        {
            Console.Write("Enter your bet (or type 'quit' to exit): ");

            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                Console.WriteLine("Thanks for playing! Goodbye.");
                break;
            }

            if (int.TryParse(userInput, out int bet) && bet > 0 && bet <= playerMoney)
            {
                SpinSlots(bet);
            }
            else
            {
                Console.WriteLine("Invalid bet. Please enter a valid amount.");
            }
        }
    }

    static void SpinSlots(int bet)
    {
        char[] symbols = { '♠', '♥', '♦', '♣' };
        char[] slots = new char[3];

        Random random = new Random();

        // Spin the slots
        for (int i = 0; i < 3; i++)
        {
            int randomIndex = random.Next(symbols.Length);
            slots[i] = symbols[randomIndex];
        }

        // Display the result
        Console.WriteLine($"Result: [{slots[0]}] [{slots[1]}] [{slots[2]}]");

        // Check for a win
        if (slots[0] == slots[1] && slots[1] == slots[2])
        {
            int winnings = bet * 100; // Win double the bet
            playerMoney += winnings;
            Console.WriteLine($"Congratulations! You win {winnings} fake money.");
        }
        else
        {
            playerMoney -= bet;
            Console.WriteLine($"Sorry, you lose {bet} €. Try again!");
        }

        Console.WriteLine($"You now have {playerMoney} €.");
        Console.WriteLine(); // Add a newline for better readability
    }
}

    