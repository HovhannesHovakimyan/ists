using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Translit_to_Armenian_Converter
{
    public enum TransliterationType
    {
        Gost,
        ISO
    }
    public static class Transliteration
    {
        private static Dictionary<string, string> gost = new Dictionary<string, string>(); //ГОСТ 16876-71
        private static Dictionary<string, string> iso = new Dictionary<string, string>(); //ISO 9-95

        public static string Front(string text)
        {
            return Front(text, TransliterationType.ISO);
        }
        public static string Front(string text, TransliterationType type)
        {
            string output = text;
            Dictionary<string, string> tdict = GetDictionaryByType(type);

            foreach (KeyValuePair<string, string> key in tdict)
            {
                output = output.Replace(key.Key, key.Value);
            }
            return output;
        }
        public static string Back(string text)
        {
            return Back(text, TransliterationType.ISO);
        }
        public static string Back(string text, TransliterationType type)
        {
            string output = text;
            Dictionary<string, string> tdict = GetDictionaryByType(type);

            foreach (KeyValuePair<string, string> key in tdict)
            {
                output = output.Replace(key.Value, key.Key);
            }
            return output;
        }

        private static Dictionary<string, string> GetDictionaryByType(TransliterationType type)
        {
            Dictionary<string, string> tdict = iso;
            if (type == TransliterationType.Gost) tdict = gost;
            return tdict;
        }

        static Transliteration()
        {
            gost.Add("a", "ա");
            gost.Add("b", "բ");
            gost.Add("c", "ց");
            gost.Add("d", "դ");
            gost.Add("e", "ե");
            gost.Add("f", "ֆ");
            gost.Add("g", "գ");
            gost.Add("h", "հ");
            gost.Add("i", "ի");
            gost.Add("j", "ջ");
            gost.Add("k", "կ");
            gost.Add("l", "լ");
            gost.Add("m", "մ");
            gost.Add("n", "ն");
            gost.Add("o", "ո");
            gost.Add("p", "պ");
            gost.Add("q", "ք");
            gost.Add("r", "ռ");
            gost.Add("s", "ս");
            gost.Add("t", "տ");
            gost.Add("u", "ու");
            gost.Add("v", "վ");
            gost.Add("w", "վ");
            gost.Add("x", "խ");
            gost.Add("y", "յ");
            gost.Add("z", "զ");

            iso.Add("a", "ա");
            iso.Add("b", "բ");
            iso.Add("c", "ց");
            iso.Add("d", "դ");
            iso.Add("e", "ե");
            iso.Add("f", "ֆ");
            iso.Add("g", "գ");
            iso.Add("h", "հ");
            iso.Add("i", "ի");
            iso.Add("j", "ջ");
            iso.Add("k", "կ");
            iso.Add("l", "լ");
            iso.Add("m", "մ");
            iso.Add("n", "ն");
            iso.Add("o", "ո");
            iso.Add("p", "պ");
            iso.Add("q", "ք");
            iso.Add("r", "ռ");
            iso.Add("s", "ս");
            iso.Add("t", "տ");
            iso.Add("u", "ու");
            iso.Add("v", "վ");
            iso.Add("w", "վ");
            iso.Add("x", "խ");
            iso.Add("y", "յ");
            iso.Add("z", "զ");
        }
    }
}
