namespace gun5
{
    class Fish : Animal, ISwimmable
    {
        public Fish(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " blub blub");
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " yemek yer");
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " uyur");
        }
        public void Swim()
        {
            Console.WriteLine(Name + " yüzer");
        }
    }
}