using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Utilitaires
{
    public static class UtilitaireAPI
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nbParagraphes"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static String RecupereLoremIpsum(int nbParagraphes)
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/text"));
            String url = $"https://loripsum.net/api/{nbParagraphes}/short/plaintext";
            var response = client.GetAsync(url).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                return responseBody;
            }
            else
            {
                throw new Exception($"Erreur API : {response.StatusCode} {response.ReasonPhrase}");
            }
        }
    }
}
