
using System.Reflection.Metadata.Ecma335;

start();

static void start()
{
    string[,] carBrand = new string[,] { 
        { "Ford", "Escape" }, { "Ford", "Edge" }, { "Ford", "Fusion" },
        {"Honda", "Accord" }, {"Honda", "Civic"}, {"Honda", "Pilot"}
    }; //Car brands stored in 2d array

    Console.WriteLine("Welcome to Scooter's dealership.  Are you looking for a Ford or Honda today?");
    string userSelection = ""; 
    userSelection = Console.ReadLine(); //User input for brand selection


    Console.WriteLine("Ok.  Let's check and see what we have in stock");
    Console.WriteLine(new string('-', 60));

    bool isBrandAvailable = checkBrandAvailability(userSelection, carBrand); // calling checkBrandAvailability function to check brand availability and return bool value

    if (isBrandAvailable) //based on return bool value, prints car brand and models if true
    {
        for (int i = 0; i < carBrand.GetLength(0); i++)
        {
            if (carBrand[i,0].ToLower() == userSelection.ToLower())
                Console.WriteLine($"- {carBrand[i,0]} {carBrand[i,1]}");
        }

    }
    else // print's non availability message
    {
        Console.WriteLine($"Sorry we don't have any {userSelection}");
    }
}

static bool checkBrandAvailability(string userSelection, string[,] carBrand) // function checks car brand avilability
{
    for(int i=0; i<carBrand.GetLength(0); i++)
    {
        if (carBrand[i,0].ToLower() == userSelection.ToLower()) return true;
    }
    return false;
}