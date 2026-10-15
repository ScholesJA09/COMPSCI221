using System.Globalization;

namespace COMPSCI221
{
    abstract class Item
    {
        protected double price;
        protected string model;
        protected string manufacturer;

        public Item(double price, string model, string manufacturer)
        {
            Price = price;
            Model = model;
            Manufacturer = manufacturer;
        }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative");
                }
                price = value;
            }
        }

        public string Model
        {
            get => model;
            set
            {   
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Model cannot be null or zero length.");
                }
                model = value;
            }
        }

        public string Manufacturer
        {
            get => manufacturer;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Manufacturer cannot be null or zero length.");
                }
                manufacturer = value;
            }
        }
    }
}
