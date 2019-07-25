using System;
using System.Collections.Generic;

namespace ConsoleApp1.CallbackHandler
{
    public class MyCallBackHandler : FTServer.Operator.CallbackHandler
    {
        public const int OperatorCode = 20;
        public void Send(string packet)
        {
            //send packet to server
            gameService.Deliver(MyCallBackHandler.OperatorCode, new Dictionary<byte, object>(){ {0,packet }});
        }

        public override void ServerCallback(Dictionary<byte, object> server_packet)
        {
            //get something from server
            Console.WriteLine("Msg from server : " + server_packet[0].ToString());     
        }
    }
}