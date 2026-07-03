namespace gun5
{
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine(Name + " cıvıldar");
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
