Start();
static void Start()
{
    int count = 0;
    Console.WriteLine("Enter count");
    int lines = int.Parse(Console.ReadLine());
    while (count!=lines*2)
    {
        // Print
        for (int i = 0; i < 20; i++)
        {
            Console.Write("-X");
            Thread.Sleep(100);
        }

        // move to next line
        Console.WriteLine();
        count++;

        // blank line after every 2 lines
        if (count % 2 == 0)
        {
            Console.WriteLine();
        }
    }
}
