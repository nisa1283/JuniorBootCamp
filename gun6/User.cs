namespace gun6
{
    public abstract class User
    {
        public string Name { get; set; }
        public string Id { get; set; }

        protected User(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}
