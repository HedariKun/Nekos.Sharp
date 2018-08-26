using System;
using Newtonsoft.Json;

 namespace Nekos.Sharp.Responses
 {
     public class NekoWhy
     {
         [JsonProperty("why")]
         public string Why;
     }
 }