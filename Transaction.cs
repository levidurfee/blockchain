namespace blockchain
{
    class Transaction
    {
        public string Data { get; }

        public Transaction(string input)
        {
            Data = input;
        }
    }
}
