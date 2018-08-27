# Nekos.Sharp
Nekos sharp is a wrapper that is used to get images from the service [Nekos.life](https://nekos.life/)
to get starting you need to implement the nameSpace 
```cs
using Nekos.Sharp
```

to get Images you need to use the static Method GetImageAsync from NekoClient then you need to choose the image title you can choose from sfw and nsfw image 

 Examples 
 ```cs
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
           /*
            For Nsfw Image Change SFWTypes To NSFWTypes
            NekoImg Data = await NekoClient.GetImageAsync(SFWTypes.Lewd);
           */
            NekoImg Data = await NekoClient.GetImageAsync(SFWTypes.Hug);
            /*
             you can get Fact by doing
             NekoFact Data = await NekoClint.GetFactAsync();
             then you can get it from Data.Fact;
             or you can get why 
             NekoWhy Data = await NekoClient.GetWhyAsync();
             then you can get it from Data.Why;
            */
            Console.Write(Data.ImageURl);
            Console.ReadKey();
        }
    }
}
```

Why Object Example
```cs
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

            NekoWhy Data = await NekoClient.GetWhyAsync();
            Console.Write(Data.Why);
            Console.ReadKey();
        }
    }
}
```
Fact Object Example 
 ```cs
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
```

