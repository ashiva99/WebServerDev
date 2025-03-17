namespace FavoriteHobbies_W00391044.Models
{
    public class Hobby
    {
        public readonly string name;
        public readonly int age;
        public readonly bool active; 

        public Hobby(string name, int age, bool active)
        {
            this.name = name;
            this.age = age;
            this.active = active;
        }
    }
}
