namespace COMPSCI221
{
    internal class Laptop : Computer
    {
        protected int batteryLifeTime;
        public Laptop(double price, string model, string manufacturer, int storage, int batteryLife) : base(price, model, manufacturer, storage) 
        {
            BatteryLife = batteryLife;
        }

        public override string ToString()
        {
            return $"The {manufacturer} {model} laptop (${price:N}) has {storage} GB of storage and {batteryLifeTime} hours of battery life";
        }

        public int BatteryLife
        {
            get => batteryLifeTime;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Battery life must be positive.");
                }
                batteryLifeTime = value;
            }
        }
    }
}
