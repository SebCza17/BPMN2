using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace BPMN
{
    class RestApp
    {

        private byte[] authenticationByte = Encoding.ASCII.GetBytes("kermit:kermit");

        private static string address = "http://192.168.99.100:8080/";
        public HttpClient httpClient { get; }
        public RestApp()
        {
            httpClient = new HttpClient();

            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authenticationByte));
        }
        
        public string makeGet(string url)
        {
            return httpClient.GetStringAsync(address + url).Result;
        }
    }
}
