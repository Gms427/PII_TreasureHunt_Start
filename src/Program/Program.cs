using System;
using Vigenere.Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            VigenereCode v = new VigenereCode("ucu", 8);
            VigenereCode vLowerCase = new VigenereCode("ucu", 0);
            VigenereCode vLowerCaseSalt = new VigenereCode("ucu", 5);
            string result = vLowerCase.Decrypt("jtiatugcwcqhck");
            string result2 = vLowerCaseSalt.Decrypt("OYNFYZLHBHVMHP");
            string result3 = vLowerCase.Encrypt("programacionii");
            Console.WriteLine(v.Decrypt("ISVJED"));
            Console.WriteLine(v.Decrypt("WMWFKN"));
            Console.WriteLine(v.Decrypt("TORQ"));
            Console.WriteLine(v.Decrypt("JSFFOP"));
        }
    }
}
