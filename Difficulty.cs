using System;

namespace blockchain
{
    class Difficulty
    {
        public int Size;
        public string DifficultyString = "";

        public Difficulty(int size)
        {
            Size = size;

            for(int i=0; i<size; i++) {
                DifficultyString += "0";
            }
        }

        public bool Check(string hash)
        {
            return hash.Substring(0, Size) == DifficultyString;
        }
    }
}
