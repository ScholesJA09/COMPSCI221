using System.Reflection.Metadata.Ecma335;

namespace COMPSCI221
{
    class Order
    {
        private int id;
        private double price;
        private OrderStatus status;
        private OrderType type;

        public Order(int id, double price, OrderStatus status, OrderType type)
        {
            if (id < 1000 || id > 9999)
            {
                throw new Exception("ID must be between 1000-9999.");
            }
            this.id = id;

            Price = price;
            Status = OrderStatus.New;
            Type = type;
        }

        public override string ToString()
        {
            switch (status)
            {
                case OrderStatus.New:
                    return $"New {type} Order #{id} received";
                    break;
                case OrderStatus.Preparing:
                    return $"{type} Order #{id} is being prepared";
                    break;
                case OrderStatus.Ready:
                    switch (type)
                    {
                        case OrderType.DineIn:
                            return $"Order #{id} is ready to be served";
                            break;
                        case OrderType.TakeOut:
                            return $"Order #{id} is ready for pickup";
                            break;
                        case OrderType.Delivery:
                            return $"Order #{id} is ready to be delivered";
                            break;
                        default:
                            return $"Order #{id} has unsupported type {type}";
                    }
                    break;
                case OrderStatus.Completed:
                    return $"{type} Order #{id} completed - customer paid ${price}";
                    break;
                case OrderStatus.Cancelled:
                    return $"{type} Order #{id} cancelled";
                    break;
                default:
                    return $"{type} Order #{id} has unsupported status {status}";
            }
        }

        public int Id
        {
            get => id;
        }

        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Price cannot be negative.");
                }
                price = value;
            }
        }

        public OrderStatus Status
        {
            get => status;
            set
            {
                status = value;
            }
        }

        public OrderType Type
        {
            get => type;
            set
            {
                type = value;
            }
        }
    }
}
