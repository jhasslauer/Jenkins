using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForgeLauncher
{
    public class WebService
    {

        public WebService()
        {
        }

        public string downloadData(string _url)
        {
            WebClient client = new WebClient();
            string url = Launcher.scriptsFolder + _url;
            byte[] html = client.DownloadData(url);
            UTF8Encoding utf = new UTF8Encoding();
            string mystring = utf.GetString(html);

            return mystring;
        }

        public async Task<string> postJsonAsync(string url, string json)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Launcher.scriptsFolder);
                    StringContent jsonContent = new StringContent(json);
                    var result = await client.PostAsync(url, jsonContent);
                    return await result.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException rex)
            {
                return "error";
            }
        }

        public async Task<string> getStringAsync(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Launcher.scriptsFolder);
                    var result = await client.GetStringAsync(url);

                    return result;
                }
            }
            catch (HttpRequestException rex)
            {
                return "error";
            }
        }

        public async Task<string> getJsonAsync(string url)
        {
            try {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Launcher.scriptsFolder);
                    var result = await client.GetStringAsync(url);

                    if (result != null || result != "")
                    {
                        /*result = result.Replace("\n", "");
                        result = result.Replace("\\", "");
                        result = result.Remove(0, result.IndexOf("["));
                        result = result.Remove(result.IndexOf("]") + 1);*/
                    }
                    else
                    {
                        return "empty";
                    }

                    return result;
                }
            }
            catch (HttpRequestException rex)
            {
                return "error";
            }
        }

        
    }
}
