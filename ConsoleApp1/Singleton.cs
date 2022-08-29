using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Singleton
    {

        public static Singleton _singletone;

        private Singleton()
        {

        }
        public static Singleton getSingleTon()
        {
            if(_singletone is null)
            {
                _singletone = new Singleton();
            } 
            return _singletone;
        }

        public void GetAPIcall()
        {
            using (var httpClient = new HttpClient())
            {
                //httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos");
                var respone = httpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                respone.Wait();
                if(respone.IsCompletedSuccessfully)
                {
                    var readTask = respone.Result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    var userData = readTask.Result;
                    var data = JsonConvert.DeserializeObject<List<UserModel>>(userData);
                }
            }
        }

        public class UserModel
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public bool completed { get; set; }
        }
    }
}
