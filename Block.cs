using System.Collections.Generic;

namespace blockchain
{
    class Block
    {
        public uint id { get; }
        public List<Transaction> Transactions;

        public readonly string version = "v0.1.0";

        public readonly string nonce = "";

        public readonly Hash PreviousHash;

        public Block(uint blockid, Hash previousHash)
        {
            id = blockid;

            Transactions = new List<Transaction>();
            PreviousHash = previousHash;
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public Hash ProcessBlock()
        {
            string data = PreviousHash.Data;

            foreach(Transaction transaction in Transactions) {
                data += transaction.Data;
            }

            return new Hash(data);
        }
    }
}
