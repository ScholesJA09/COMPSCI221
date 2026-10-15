using System.Drawing;

namespace COMPSCI221
{
    abstract class Computer : Item
    {
        protected int storage;
        public Computer(double price, string model, string manufacturer, int storage) : base(price, model, manufacturer)
        {
            Storage = storage;
        }

        public override string ToString()
        {
            return $"The {manufacturer} {model} (${price:N}) has {storage} GB of storage";
        }

        public int Storage
        {
            get => storage;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Storage must be positive.");
                }
                storage = value;
            }

        }
    }
}
