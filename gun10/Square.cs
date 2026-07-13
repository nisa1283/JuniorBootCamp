namespace gun10
{
    public class Square : IShape
    {
        public int Side { get; set; }

        public Square (int side)
        {
            Side = side;
        }
        public int Area()
        {
            return Side * Side;
        }
    }
}