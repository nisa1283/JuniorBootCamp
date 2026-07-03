namespace gun5
{
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }
        public override void MakeSound()
        {
            Console.WriteLine(Name + " havlar");
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
