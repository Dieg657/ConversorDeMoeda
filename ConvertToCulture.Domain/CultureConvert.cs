using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConvertToCulture.Domain
{
    public static class CultureInformation
    {
        private const string en_US = "en-US";
        private const string pt_BR = "pt-BR";
        private const string ja_JP = "ja-JP";
        private const string es_ES = "es-ES";
        private const string fr_FR = "fr-FR";
        private const string de_DE = "de_DE";
        private static readonly List<string> Cultures = new List<string>() { en_US, pt_BR, ja_JP, es_ES, fr_FR, de_DE };

        public static string SetCulture(string infoCulture)
        {
            var res = Cultures.Where(x => x == infoCulture).FirstOrDefault();
            if (res == null)
                throw new Exception("Culture not found!");
            else
                return res;
        }

        public static bool IsNumber(string value)
        {
            try
            {
                double.Parse(value);
                return true;
            }
            catch (System.Exception)
            {

                throw new Exception("Isn't a number!");
            }
        }
    }
    public static class CultureConvert
    {
        public static string ValueToCulture(string value, string culture)
        {
            var cultureLang = new CultureInfo(culture);
            var output = double.Parse(value, cultureLang);
            return output.ToString("c",CultureInfo.InvariantCulture);
        }
    }
}
