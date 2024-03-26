namespace _04._Wild_Farm
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal.Animal> animals = new List<Animal.Animal>();
            string input = string.Empty;
            int count = 0;

            while ((input = Console.ReadLine()) != "End")
            {
                Animal.Animal animal = Factory.GetAnimal(input);
                animal.Sound();
                Food.Food food = Factory.GetFood(Console.ReadLine());
                animal.Eat(food);
                animals.Add(animal);
            }

            foreach (Animal.Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}