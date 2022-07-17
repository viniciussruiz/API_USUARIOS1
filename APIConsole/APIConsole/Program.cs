using Newtonsoft.Json;
using QuickType;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace APIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient { BaseAddress = new Uri("https://jsonplaceholder.typicode.com") };
            var response = await client.GetAsync("users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<User[]>(content);

            foreach(var i in users)
            {
                Console.WriteLine(i.Name+"\n"+"\n"+i.Email+"\n"+"\n"+i.Company+"\n"+"\n"+i.Address+"\n"+"\n"+"-------------------------------------------------------------------"+"\n");
            }

            
        }
    }
}

