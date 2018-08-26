using System;
using System.Threading.Tasks;
using Nekos.Sharp;
using Nekos.Sharp.Responses;

namespace Example
{
    class Program
    {
        static async Task Main(string[] args)
        {
            NekoFact Data = await NekoClient.GetFactAsync();
            Console.Write(Data.Fact);
            Console.ReadKey();
        }
    }
}
