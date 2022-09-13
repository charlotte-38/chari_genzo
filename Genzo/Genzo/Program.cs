using System;

namespace Genzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck Starter = new Deck();
            Console.WriteLine(Starter.DeckGetCard());
            Starter.DeckShuffle();
            _ = Console.ReadKey();
        }
    }
}
