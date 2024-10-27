using Shared;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apricot", "orange", "banana", "mango", "apple", "grape", "strawberry" };
            var ReversedFruits = fruits.Reverse();
            ReversedFruits.Print("Reversed Fruits ");
        }
    }
}
