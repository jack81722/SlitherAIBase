using ConsoleApp1;
using ConsoleApp1.Tool;
using GameServer;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace TestAI
{
    class Program
    {
        const string userKey = "0452DA61-B201-49A4-B403-37B0760FFBCB";
        //http://35.187.146.144:30001/   //35.229.204.195
        private const string agentServerIP = "http://34.67.164.19:30001/"; //slither dev  http://192.168.2.5:30001
        static void Main(string[] args)
        {
            //for (int i = 0; i < 1000; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        var id = Guid.NewGuid().ToString();
            //        Stopwatch stopWatch = Stopwatch.StartNew();
            //        string res = Authentication("http://34.67.164.19:30003/", id);
            //        stopWatch.Stop();
            //        Console.WriteLine($" {id}, res: {res}, time: {stopWatch.ElapsedMilliseconds}");
            //    });
            //}
            //Console.ReadLine();

            //for (int i = 0; i < 1000; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Stopwatch stopWatch = Stopwatch.StartNew();
            //        Urls url = QueryIP(agentServerIP);
            //        stopWatch.Stop();
            //        Console.WriteLine($" res: {url.UserUrl}, time: {stopWatch.ElapsedMilliseconds}");
            //    });
            //}
            //Console.ReadLine();

            Console.WriteLine("Hello World!");
            List<GamerEntity> gamers = new List<GamerEntity>();
            for (int i = 0; i < 1000; i++)
            {
                gamers.Add(StartAI(Guid.NewGuid().ToString()));
                Console.WriteLine($"AI 蛇 : {i}");
            }
            Console.WriteLine("Create Finish");
            Console.ReadLine();

            GamerEntity StartAI(string devicedId)
            {
                GamerEntity ai = new GamerEntity(devicedId);
                ai.Start(agentServerIP, new ConsoleBotProxy());
                return ai;
            }
        }
        public static string Authentication(string url, string devicedId)
        {
            var client = new RestClient(url);
            var request = new RestRequest("Authentication");
            var input = JsonConvert.SerializeObject(new { DeviceID = devicedId, SecretOpenID = "" });
            input = StringEncrypt.Encrypt(input, userKey);
            request.AddParameter("application/json", input, ParameterType.RequestBody);

            var response = client.Post(request);
            var content = StringEncrypt.Decrypt(response.Content, userKey);

            var definition = new { Code = "", Msg = "", AccessToken = "" };
            var result = JsonConvert.DeserializeAnonymousType(content, definition);

            return result.AccessToken;
        }
        private static Urls QueryIP(string agentServerIP)
        {
            var input = JsonConvert.SerializeObject(new { ClientVersion = "1.9.1", LoginType = "Dev" });
            input = StringEncrypt.Encrypt(input, userKey);

            Uri agentServer = new Uri(agentServerIP);
            var client = new RestClient(agentServer);
            var request = new RestRequest("QueryIP");

            request.AddParameter("Json", input, ParameterType.QueryString);
            var response = client.Post(request);
            var content = response.Content;

            return JsonConvert.DeserializeObject<Urls>(content);
        }
    }
}
