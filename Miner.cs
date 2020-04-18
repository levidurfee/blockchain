using System;

namespace blockchain
{
    class Miner
    {
        public string Process(Block block, Difficulty difficulty)
        {
            Random rand = new Random();

            bool looking = true;

            int tmp;
            string hash;
            string blockHash = block.ProcessBlock().Data;

            do {
                tmp = rand.Next();
                hash = Hash.SHA512(blockHash + tmp.ToString());
                if(difficulty.Check(hash)) {
                    looking = false;
                }
                //Console.Write(".");
            } while(looking);

            //Console.Write("\n");

            return tmp.ToString();
        }
    }
}
