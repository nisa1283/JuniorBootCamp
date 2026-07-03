namespace gun5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Dog("Karabaş", 5));
            zoo.AddAnimal(new Cat("Mimi", 3));
            zoo.AddAnimal(new Bird("Sarı", 2));

            zoo.ShowAnimals();
            zoo.FindAnimal("Mimi")?.MakeSound();
            zoo.FindAnimal("Karabaş")?.Eat();
            zoo.DeleteAnimal(zoo.FindAnimal("Sarı")!);
            Console.WriteLine("Hayvan sayısı: " + zoo.AnimalCount());
            Console.WriteLine("Mimi adında bir hayvan var mı? " + (zoo.Contains("Mimi") ? "Evet" : "Hayır"));


        }
    }
}