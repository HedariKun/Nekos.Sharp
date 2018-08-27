using System;
using System.Collections.Generic;

namespace Nekos.Sharp
{
        public enum SFWTypes
        {
            WallPaper,
            NekoGif,
            Meow,
            Tickle,
            Feed,
            Gecg,
            Kemonomimi,
            Gasm,
            Poke,
            Slap,
            Avatar,
            Lizard,
            Waifu,
            Pat,
            Kiss,
            Neko,
            Cuddle,
            FoxGirl,
            Hug,
            Baka,
            Smug
        }
    public class SFWImageType
    {
        private const Dictionary< SFWTypes, string> Dictionary = new Dictionary< SFWTypes, string>()
        {
            {SFWTypes.WallPaper, "wallpaper"},
            {SFWTypes.NekoGif, "ngif"},
            {SFWTypes.Meow, "meow"},
            {SFWTypes.Tickle, "tickle"},
            {SFWTypes.Feed, "feed"},
            {SFWTypes.Gecg, "gecg"},
            {SFWTypes.Kemonomimi, "kemonomimi"},
            {SFWTypes.Gasm, "gasm"},
            {SFWTypes.Poke, "poke"},
            {SFWTypes.Slap, "slap"},
            {SFWTypes.Avatar, "avatar"},
            {SFWTypes.Lizard, "lizard"},
            {SFWTypes.Waifu, "waifu"},
            {SFWTypes.Pat, "pat"},
            {SFWTypes.Kiss, "kiss"},
            {SFWTypes.Neko, "neko"},
            {SFWTypes.Cuddle, "cuddle"},
            {SFWTypes.FoxGirl, "fox_girl"},
            {SFWTypes.Hug, "hug"},
            {SFWTypes.Baka, "baka"},
            {SFWTypes.Smug, "smug"}
        };

        public static string GetSfwValue( SFWTypes Type)
        {
            string Value;
            Dictionary.TryGetValue(Type, out Value);
            return Value;
        }
    }
}
