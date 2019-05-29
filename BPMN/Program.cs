using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace BPMN
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();
            var byteArray = Encoding.ASCII.GetBytes("kermit:kermit");
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            var x = httpClient.GetStringAsync("http://192.168.99.100:8080/activiti-rest/service/repository/deployments/").Result;
            Console.WriteLine(JsonConvert.DeserializeObject<Entity.Deployments>(x));
            Console.WriteLine("TestRepo");
            Console.ReadKey();
        }
    }
}
