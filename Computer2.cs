namespace COMPSCI221
{
    internal class Computer2 : IEmailReceiver
    {
        protected string name;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name cannot be empty.");
                }
                name = value;
            }
        }

        public Computer2(string name)
        {
            Name = name;
        }

        public void ReceiveEmail(string sender, string subject)
        {
            Console.WriteLine($"*chime* from: {sender} subject: {subject}");
        }
    }
}
