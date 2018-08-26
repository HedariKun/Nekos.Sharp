using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Nekos.Sharp.EndPoints;
using Nekos.Sharp.Responses;


namespace Nekos.Sharp
{

    public class NekoClient
    {

        private static string BaseURL = "https://nekos.life/api/v2";

        public static async Task<NekoImg> GetImageAsync(SFWImages ImageType)
        {
            int imageIndex = (int)ImageType;
            NekoImg ImageData = await GetJsonRespons<NekoImg>($"{BaseURL}/img/{NekosEndPoints.SFWEndPoints[imageIndex]}");
            return ImageData;
        }

        public static async Task<NekoImg> GetImageAsync(NSFWImages ImageType)
        {
            int imageIndex = (int)ImageType;
            NekoImg ImageData = await GetJsonRespons<NekoImg>($"{BaseURL}/img/{NekosEndPoints.SFWEndPoints[imageIndex]}");
            return ImageData;
        }

        public static async Task<NekoWhy> GetWhyAsync()
        {
            NekoWhy why = await GetJsonRespons<NekoWhy>($"{BaseURL}/why");
            return why;
        }

        public static async Task<T> GetJsonRespons<T>(string Url) where T : new()
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
                }
                await Task.CompletedTask;
                return !string.IsNullOrEmpty(JsonData)? JsonConvert.DeserializeObject<T>(JsonData) : new T();

            }
        }
    }

}