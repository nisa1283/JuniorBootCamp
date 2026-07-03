namespace gun5
{
    abstract class Animal
    {
        public string Name;
        public int Age;

        public abstract void MakeSound();
        public abstract void Eat();
        public abstract void Sleep();

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
