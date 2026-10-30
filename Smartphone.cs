namespace COMPSCI221
{
    internal class Smartphone : Phone , IEmailReceiver , ITextReceiver
    {
        public Smartphone(string number) : base(number) { }

        public void ReceiveEmail(string sender, string subject)
        {
            Console.WriteLine($"*ping* new email from {sender}");
        }

        public void ReceiveText(string message)
        {
            Console.WriteLine($"*ping* new text message");
        }
    }
}
