using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class FamousQuote
    {
        public static void Kanyequote()
        {
            var client = new HttpClient();
            var kanyeUrl = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine("kanye :" +kanyeQuote);
        }
       public static void ronQuote()
        {
            var client = new HttpClient();
            var ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse= client.GetStringAsync(ronUrl).Result;
            var ronQuote= JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine("ron: "+ronQuote);
        }
    }
}
