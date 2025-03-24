using Microsoft.AspNetCore.Mvc;

namespace FavoriteAnimal_W00391044.Controllers
{
    public class AnimalController : Controller
    {
        List<String> animalList = new List<String>()
        {
            "Dog", "Cat", "Elephant"
        };
        [HttpGet]
        public List<String> PopulateAnimals() 
        {
            return animalList;
        }

        [HttpPost]
        public void AddAnimal([FromQuery] String animal)
        {
            if (!String.IsNullOrEmpty(animal))
            {
                animalList.Add(animal);
            }
        }
    }
}
