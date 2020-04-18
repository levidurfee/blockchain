using System;

namespace blockchain
{
    class Program
    {
        static void Main(string[] args)
        {
            // string genesis = Program.SHA512("2020-04-18 Levi");
            // string firstHash = "426ab3a2de72e9c70e9574ccdcd0ff30d842c92f209f3e58985e19517d1629a901de2d635f4ff475782a94471555d99ad4b4871fbf529f0c6d131d94dab107ce";
            // Console.WriteLine(firstHash);

            Block genesis = new Block(1, new Hash("2020-04-18 Levi"));
            genesis.AddTransaction(new Transaction("Hello world"));
            genesis.AddTransaction(new Transaction("Hello Frank"));

            Console.WriteLine(new Hash("2020-04-18 Levi").Data);
            Console.WriteLine("=======");

            Hash hash = genesis.ProcessBlock();

            Miner miner = new Miner();
            Difficulty difficulty = new Difficulty(3);

            string nonce = miner.Process(genesis, difficulty);
            Console.WriteLine(nonce);
            Console.WriteLine(hash.Data);

            Block block = new Block(2, new Hash(genesis.ProcessBlock().Data + nonce));
            Console.WriteLine(block.PreviousHash.Data);

            block.AddTransaction(new Transaction("dood"));
            block.AddTransaction(new Transaction("television"));
            block.AddTransaction(new Transaction("house"));
            nonce = miner.Process(block, difficulty);

            Console.WriteLine("=======");

            Console.WriteLine(nonce);
            Console.WriteLine(block.ProcessBlock().Data);
            Console.WriteLine(new Hash(block.ProcessBlock().Data + nonce).Data);
        }


    }
}
