namespace Zoo
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BorderlineHealthStatusAttribute : Attribute
    {
        public BorderlineHealthStatusAttribute(byte points)
        {
            Points = points;
        }

        public byte Points { get; private set; }
    }
}
