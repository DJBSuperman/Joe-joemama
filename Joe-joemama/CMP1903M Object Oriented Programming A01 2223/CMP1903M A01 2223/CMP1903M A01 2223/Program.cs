using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new pack of cards
            Pack pack = new Pack();

            // Shuffle the pack using different shuffle types
            pack.shuffleCardPack(1);
            Console.WriteLine("Fisher-Yates Shuffle:");
            Console.WriteLine(string.Join(", ", pack.dealCard(5)));

            pack.shuffleCardPack(2);
            Console.WriteLine("Riffle Shuffle:");
            Console.WriteLine(string.Join(", ", pack.dealCard(5)));

            pack.shuffleCardPack(3);
            Console.WriteLine("No Shuffle:");
            Console.WriteLine(string.Join(", ", pack.dealCard(5)));
        }
    }
}