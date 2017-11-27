using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlobalDatasLibrary.Datas;
using System.Globalization;
using System.Xml;
using System.Xml.Linq;

namespace GlobalDatasLibrary
{
    public static class Current
    {
        /// <summary>
        /// Gets the primary screen dimensions
        /// </summary>
        /// <returns>Primary screen dimensions</returns>
        public static Screen GetPrimaryScreen()
        {
            return new Screen();
        }

        /// <summary>
        /// Get the dimensions of all connected screens
        /// </summary>
        /// <returns>Dimension of all connected screen</returns>
        public static Screen[] GetAllScreens()
        {
            List<Screen> answer = new List<Screen>();
            foreach(var current_screen in System.Windows.Forms.Screen.AllScreens)
            {
                answer.Add(new Screen(current_screen));
            }
            return answer.ToArray();
        }

        public static string GetPhraseInCurrentLanguaje(string phrase)
        {
            string path = Environment.CurrentDirectory + @".\Resources\dictionary.xml";

            string culture = GetCurrentCulture().IetfLanguageTag;
            XDocument doc = XDocument.Load(path);

            var tmp = from x in doc.Root.Elements(phrase) select new { x.Element(culture).Value }.Value;
            return tmp.FirstOrDefault();
        }

        public static CultureInfo GetCurrentCulture()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@".\Resources\config.xml");
            string current = string.Empty;

            XmlNodeList configs = doc.GetElementsByTagName("configuration");
            foreach(XmlElement conf in configs)
            {
                var culture = conf.GetElementsByTagName("culture").Item(0);
                current = culture.InnerText;
            }

            return CultureInfo.GetCultureInfo(current);
        }
    }
}
