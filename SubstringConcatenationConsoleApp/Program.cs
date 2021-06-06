using System;
using SubstringConcatenationDomain.Models;

namespace SubstringConcatenationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "barfoothefoobarman";
            var words = new [] { "foo", "bar" };
            var indices = SuperString.FindSubstring(str, words);

            indices?.ForEach(indice => Console.Write($"{indice} "));
        }
    }
}
