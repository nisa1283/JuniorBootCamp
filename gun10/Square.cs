namespace gun10
{
    public class Square : Rectangle
    {
        public Square(int side) : base(side, side)
        {
        }

        public override int Width
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
            get => base.Width;
        }

        public override int Height
        {
            set
            {
                base.Width = value;
                base.Height = value;
            }
            get => base.Height;
        }
    }
}