using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nekos.Sharp.Responses;


namespace Nekos.Sharp
{

    public class NekoClient
    {

        private static string BaseURL = "https://nekos.life/api/v2";

        public static async Task<NekoImg> GetImageAsync(SFWTypes ImageType) 
        {
             return await GetImageData(SFWImageType.GetSfwValue(ImageType));
        }
        public static async Task<NekoImg> GetImageAsync(NSFWTypes ImageType) 
        {
             return await GetImageData(NSFWImageTypes.GetNsfwValue(ImageType));
        }
        private static async Task<NekoImg> GetImageData(string Value)
        {
            NekoImg ImageData = await GetJsonResponse<NekoImg>($"{BaseURL}/img/{Value}");
            return ImageData;
        }
        public static async Task<NekoWhy> GetWhyAsync()
        {
            NekoWhy why = await GetJsonResponse<NekoWhy>($"{BaseURL}/why");
            return why;
        }

        public static async Task<NekoFact> GetFactAsync()
        {
            NekoFact Fact = await GetJsonResponse<NekoFact>($"{BaseURL}/fact");
            return Fact;
        }

        private static async Task<T> GetJsonResponse<T>(string Url) where T : new()
        {
            using(WebClient Web = new WebClient())
            {
                string JsonData = string.Empty;
                try
                {
                    JsonData = Web.DownloadString(Url);
                } 
                catch(Exception)
                {
                    throw new Exception("Error in connecting to the API.");
                }
                await Task.CompletedTask;
                return !string.IsNullOrEmpty(JsonData)? JsonConvert.DeserializeObject<T>(JsonData) : new T();

            }
        }
    }

}