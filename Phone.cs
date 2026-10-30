namespace COMPSCI221
{
    internal class Phone : ICallReceiver
    {
        protected string number;

        public string Number
        {
            get => number;
            set
            {
                if (value == null || value.Length != 10)
                {
                    throw new Exception("Number has to be 10 digits long.");
                }
                number = value;
            }
        }

        public Phone(string number)
        {
            Number = number;
        }

        public void ReceiveCall(string callerNumber)
        {
            Console.WriteLine($"*ring* {number} is receiving a call from {callerNumber}");
        }
    }
}