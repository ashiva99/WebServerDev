
Console.WriteLine("Hi.My name is Shiva. What is your name?"); //It will prompt user for input and take console inputs
string? name = Console.ReadLine();

Console.WriteLine("What town are you from?");
string? town = Console.ReadLine();

Console.WriteLine("What's your favorite subject in school?");
string? favSubject = Console.ReadLine();

Console.WriteLine("Do you like playing video games?");
string? playGames = Console.ReadLine();

Student S1 = new Student(name, town, favSubject, playGames); //it will create an instance of the Student class with user inputs

Console.WriteLine(S1.Welcome()); //Display the welcome message and student's info


class Student  //Class Student
{
    string Name;
    string Town;
    string FavSubject;
    string PlayGames;
    public Student(string name, string town, string favSubject, string playGames) //Constructor is created to initialize object of class assign values to fields
    {
        this.Name = name;
        this.Town = town;
        this.FavSubject = favSubject;
        this.PlayGames = playGames;
    }
    public string Welcome() //This method returns with greetings and condition to check if person likes video games.
    {
        return $"Hi {this.Name}. I am from {this.Town} too. {this.FavSubject} is interesting. " +
            $"{(this.PlayGames.ToLower().StartsWith("y") ? "\nI like playing video games too." : "")}";
    }
}
