using ConsoleApp1;
using GameServer;
using System;

namespace TestAI
{
    class Program
    {
        private const string agentServerIP = "http://35.187.146.144:30001/"; //slither dev  http://192.168.2.5:30001
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var gameEntity = StartAI(Guid.NewGuid().ToString());
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
