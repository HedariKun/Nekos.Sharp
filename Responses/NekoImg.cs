using System;
using Newtonsoft.Json;

namespace Nekos.Sharp.Responses
{
    public class NekoImg
    {
        [JsonProperty("url")]
        public string ImageURl{get; set;}
    }
}