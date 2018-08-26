using Newtonsoft.Json;

namespace Nekos.Sharp.Responses
{
    public class NekoFact
    {
        [JsonProperty("fact")]
        public string Fact;
    }
}