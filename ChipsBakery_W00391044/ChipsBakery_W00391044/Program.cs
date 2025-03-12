
start();

static void start()
{
    int muffinsCount;
    int cookiesCount;
    const double price = 2.75;

    Console.WriteLine("Welcome to Chips Bakery \r\nWe have muffins and cookies");
    Console.Write("How many muffins would you like? ");
    muffinsCount= Convert.ToInt16(Console.ReadLine());
    Console.Write("How many cookies would you like? ");
    cookiesCount = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine($"Okay great.  You ordered {muffinsCount} muffins and {cookiesCount} cookies.");
    Console.WriteLine($"That will cost ${(muffinsCount+cookiesCount)*price}");

}