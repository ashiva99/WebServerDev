//This assignment is about generating 20 random numbers in console between 1 and 100 
start();

static void start()
{
    int num;
    Console.Write("How many random numbers do you want to generate today? (Between 1 and 20): ");

    num = Convert.ToInt16(Console.ReadLine());

    if (num > 0 && num <= 20)
    {
        for (int i = 0; i<num; ++i)
        {
            Console.WriteLine(RandomNumberGenerator());
        }
    }
    else
    {
        Console.WriteLine("Please try again");
        start();
    }
}

static int RandomNumberGenerator()
{
    Random rnd = new Random();
    return rnd.Next(1,100);
}