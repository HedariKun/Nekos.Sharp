using System;
using System.Threading.Tasks;
using Nekos.Sharp;
using Nekos.Sharp.Responses;

namespace Nekos_Sharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            NekoWhy Data = await NekoClient.GetWhyAsync();
            Console.Write(Data.Why);
            Console.ReadKey();
        }


    }
}
