using System.Data.SqlTypes;

namespace COMPSCI221
{
    internal class Television : Item
    {
        protected int size;
        public Television(double price, string model, string manufacturer, int size) : base(price, model, manufacturer) 
        {
            Size = size;
        }

        public override string ToString()
        {
            return $"The {manufacturer} {model} television (${price:N}) is {size}\"";
        }

        public int Size
        {
            get => size;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Size must be positive.");
                }
                size = value;
            }
        }
    }
}
