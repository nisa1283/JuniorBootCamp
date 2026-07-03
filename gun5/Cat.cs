namespace gun5
{
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " miyavlar");
        }
        public override void Eat()
        {
            Console.WriteLine(Name + " yemek yer");
        }
        public override void Sleep()
        {
            Console.WriteLine(Name + " uyur");
        }


    }
}
