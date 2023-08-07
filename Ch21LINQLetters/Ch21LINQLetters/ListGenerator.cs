using System;
using System.Collections.Generic;

namespace Ch21LINQLetters
{
    public class ListGenerator
    {
        private static int listSize = 30;

        private static char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static List<char> NewList()
        {
            var rand = new Random();

            List<char> list = new List<char>();

            // populate the list with random letters
            for (int i = 0; i < listSize; i++)
            {
                list.Add(alphabet[rand.Next(alphabet.Length)]);
            }

            return list;
        }
    }
}
