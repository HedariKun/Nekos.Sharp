using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Nekos.Sharp
{
    public enum NSFWTypes
    {
        HentaiGif,
        Pussy,
        NSFWNekoGif,
        Lewd,
        Les,
        Kuni,
        Cum,
        Classic,
        Boobs,
        Bj,
        Anal,
        Yuri,
        Trap,
        Tits,
        SmallBoobs,
        PussyJpg,
        Hentai,
        CumJpg,
        Solo,
        Futanari,
        HoloLewd,
        Lewdk,
        Spank,
        Erokemo,
        Ero,
        Erofeet,
        Blowjob,
        Erok,
        Keta,
        Eroyuri,
        Eron,
        Holoero,
        Solog,
        Feetg,
        NsfwAvatar,
        Feet,
        Holo,
        Femdom,
        Pwankg,
        LewdKemo  
    }

    public class NSFWImageTypes
    {
        private const Dictionary<NSFWTypes, string> Dictionary = new Dictionary<NSFWTypes, string>()
        {
            {NSFWTypes.HentaiGif, "Random_hentai_gif"},
            {NSFWTypes.Pussy, "pussy"},
            {NSFWTypes.NSFWNekoGif, "nsfw_neko_gif"},
            {NSFWTypes.Lewd, "lewd"},
            {NSFWTypes.Les, "les"},
            {NSFWTypes.Kuni, "kuni"},
            {NSFWTypes.Cum, "cum"},
            {NSFWTypes.Classic, "classic"},
            {NSFWTypes.Boobs, "boobs"},
            {NSFWTypes.Bj, "bj"},
            {NSFWTypes.Anal, "anal"},
            {NSFWTypes.Yuri, "yuri"},
            {NSFWTypes.Trap, "trap"},
            {NSFWTypes.Tits, "tits"},
            {NSFWTypes.SmallBoobs, "smallboobs"},
            {NSFWTypes.PussyJpg, "pussy_jpg"},
            {NSFWTypes.Hentai, "hentai"},
            {NSFWTypes.CumJpg, "cum_jpg"},
            {NSFWTypes.Solo, "solo"},
            {NSFWTypes.Futanari, "futanari"},
            {NSFWTypes.HoloLewd, "hololewd"},
            {NSFWTypes.Lewdk, "lewdk"},
            {NSFWTypes.Spank, "spank"},
            {NSFWTypes.Erokemo, "erokemo"},
            {NSFWTypes.Ero, "ero"},
            {NSFWTypes.Erofeet, "erofeet"},
            {NSFWTypes.Blowjob, "blowjob"},
            {NSFWTypes.Erok, "erok"},
            {NSFWTypes.Keta, "keta"},
            {NSFWTypes.Eroyuri, "eroyuri"},
            {NSFWTypes.Eron, "eron"},
            {NSFWTypes.Holoero, "holoero"},
            {NSFWTypes.Solog, "solog"},
            {NSFWTypes.Feetg, "feetg"},
            {NSFWTypes.NsfwAvatar, "nsfw_avatar"},
            {NSFWTypes.Feet, "feet"},
            {NSFWTypes.Holo, "holo"},
            {NSFWTypes.Femdom, "femdom"},
            {NSFWTypes.Pwankg, "pwankg"},
            {NSFWTypes.LewdKemo, "lewdkemo"}
        };

        public static string GetNsfwValue(NSFWTypes Type)
        {
            string Value;
            Dictionary.TryGetValue(Type, out Value);
            return Value;
        }
    }  
}
