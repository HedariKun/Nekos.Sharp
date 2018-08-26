# Nekos.Sharp
Nekos sharp is a wrapper that is used to get images from the service [Nekos.life](https://nekos.life/)
to get starting you need to implement the nameSpace 
```cs
using Nekos.Sharp
```

to get Images you need to use the static Method GetImageAsync from NekoClient then you need to choose the image title you can choose from sfw and nsfw image 

 -SFW Example 
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
            NekoImg Data = await NekoClient.GetImageAsync(SFWImages.Hug);
            Console.Write(Data.ImageURl);
            Console.ReadKey();
        }
    }
}
```

 -NSFW Example
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
            NekoImg Data = await NekoClient.GetImageAsync(NSFWImages.Lewd);
            Console.Write(Data.ImageURl);
            Console.ReadKey();
        }
    }
}
```
