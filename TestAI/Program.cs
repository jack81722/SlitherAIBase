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
        private const string agentServerIP = "http://35.229.179.186:30001/";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<GamerEntity> gamers = new List<GamerEntity>();
            for (int i = 0; i < 1; i++)
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
    }
}
