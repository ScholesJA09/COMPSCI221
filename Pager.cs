namespace COMPSCI221
{
    internal class Pager : ITextReceiver
    {
        protected int id;

        public int Id
        {
            get => id;
        }

        public Pager(int id)
        {
            if (id < 0 || id > 9999)
            {
                throw new Exception("ID must be between 0-9999.");
            }
            this.id = id;
        }

        public void ReceiveText(string text)
        {
            Console.WriteLine($"*buzz* {text}");
        }
    }
}
