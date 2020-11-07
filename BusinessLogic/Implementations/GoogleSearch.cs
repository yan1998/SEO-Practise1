using BusinessLogic.Abstractions;
using System;

namespace BusinessLogic.Implementations
{
    public class GoogleSearch : IGoogleSearch
    {
        public GoogleSearch()
        {
            Console.WriteLine("Ctor!");
        }

        public void Test()
        {
            Console.WriteLine("Test!");
        }
    }
}
