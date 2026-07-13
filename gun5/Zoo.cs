namespace gun5
{
    class Zoo
    {
        List<Animal> animals = new List<Animal>();
        Veterinarian veterinarian = new Veterinarian();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void DeleteAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void ShowAnimals()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Hayvan Adı: " + animal.Name + ", Yaşı: " + animal.Age);
                animal.MakeSound();
                animal.Eat();
                animal.Sleep();
                veterinarian.TreatAnimal(animal);
                Console.WriteLine("--------------------------");
            }
        }

        public Animal? FindAnimal(string name)
        {
            foreach (var animal in animals)
            {
                if (animal.Name == name)
                {
                    return animal;
                }
            }
            return null;
        }

        public int AnimalCount()
        {
            return animals.Count;
        }

        public bool Contains(string name)
        {
            return FindAnimal(name) != null;
        }

        public void ShowFlyingAnimals()
        {
            foreach (var animal in animals)
            {
                if (animal is IFlyable flyable)
                {
                    flyable.Fly();
                }
            }
        }

        public void ShowSwimmingAnimals()
        {
            foreach (var animal in animals)
            {
                if (animal is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
            }
        }
    }
}
