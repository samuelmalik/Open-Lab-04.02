using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string doubled = string.Empty;
            for (int i = 0; i < original.Length; i++)
            {
                doubled += original[i];
                doubled += original[i];
            }
            
            return doubled;
        }
    }
}
