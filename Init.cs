using System;
using System.Net;
using ConsoleApp1.CallbackHandler;
using ConsoleApp1.Tool;
using FTServer;
using FTServer.Example;
using FTServer.Operator;
using Newtonsoft.Json;
using RestSharp;
using SlitherEvo;

namespace ConsoleApp1
{
    public class Init
    {
        const string userKey = "0452DA61-B201-49A4-B403-37B0760FFBCB";
        public static Tuple<Urls, string, Account> Http(string agentServerIP,string devicedId)
        {
            Console.WriteLine($"devicedId: {devicedId}");
            var urls = QueryIP(agentServerIP);
            var accessToken = Authentication(urls,devicedId);
            var account = Login(urls, accessToken);
            return Tuple.Create(urls, accessToken, account);
        }

        public static Tuple<Connect,_System,LobbyHandler,GamingHandler,PacketHandler,PacketHandler> Rudp(Uri gamingServerIp)
        {
            Connect connect = new Connect(gamingServerIp.Host,gamingServerIp.Port,NetworkProtocol.RUDP);
            
            var system = new _System();
            connect.AddCallBackHandler(_System.OperatorCode, system);
            
            var gaming = new GamingHandler();
            connect.AddCallBackHandler(GamingHandler.OperationCode, gaming);

            var lobby = new LobbyHandler();
            connect.AddCallBackHandler(LobbyHandler.OperationCode, lobby);
            
            var gamePacketHandler  = new PacketHandler(PacketHandler.GamePacketOperationCode);
            connect.AddCallBackHandler(PacketHandler.GamePacketOperationCode, gamePacketHandler);
            
            var  gameRoomHandler = new PacketHandler(PacketHandler.GameRoomOperationCode);
            connect.AddCallBackHandler(PacketHandler.GameRoomOperationCode,gameRoomHandler);
            
            //establish connection
            system.Connect += () => { Console.WriteLine("Connect to server.");
            };

            return Tuple.Create(connect,system,lobby,gaming,gamePacketHandler,gameRoomHandler);
        }


        private static Urls QueryIP(string agentServerIP)
        {
            var input = JsonConvert.SerializeObject(new {ClientVersion = "1.7.2", LoginType = "beta"});
            input = StringEncrypt.Encrypt(input, userKey);

            Uri agentServer = new Uri(agentServerIP);
            var client = new RestClient(agentServer);
            var request = new RestRequest("QueryIP");

            request.AddParameter("Json", input, ParameterType.QueryString);
            var response = client.Post(request);
            var content = response.Content;

            return JsonConvert.DeserializeObject<Urls>(content);
        }

        private static string Authentication(Urls url,string devicedId)
        {
            var client = new RestClient(url.UserUrl);
            var request = new RestRequest("Authentication");
            var input = JsonConvert.SerializeObject(new {DeviceID = devicedId, SecretOpenID = ""});
            input = StringEncrypt.Encrypt(input, userKey);
            request.AddParameter("application/json", input, ParameterType.RequestBody);

            var response = client.Post(request);
            var content = StringEncrypt.Decrypt(response.Content, userKey);

            var definition = new {Code = "", Msg = "", AccessToken = ""};
            var result = JsonConvert.DeserializeAnonymousType(content, definition);

            return result.AccessToken;
        }


        public static Account Login(Urls urls, string accessToken)
        {
            var client = new RestClient(urls.UserUrl);
            var request = new RestRequest("Login");
            request.AddParameter("Authorization", accessToken, ParameterType.HttpHeader);
            var response = client.Post(request);
            var content = StringEncrypt.Decrypt(response.Content, userKey);
            var definition = new {Code = "", Msg = "", Account = new SlitherEvo.Account()};

            return JsonConvert.DeserializeAnonymousType(content, definition).Account;
        }
    }

    public class Urls
    {
        public HttpStatusCode Code;
        [JsonProperty("UserIP")] public string UserUrl;
        [JsonProperty("AgentIP")] public string AgentUrl;
        [JsonProperty("BattleIP")] public string GamingUrl;
        [JsonProperty("MetricIP")] public string MetricUrl;
        [JsonProperty("AssetsBundleIP")] public string AssetsBundleUrl;
        [JsonProperty("ServerArea")] public string ServerArea;

        public override string ToString()
        {
            return $"Code: {Code}, UserUrl: {UserUrl}, AgentUrl: {AgentUrl}, MetricUrl: {MetricUrl}, AssetsBundleUrl:{AssetsBundleUrl}, ServerArea: {ServerArea}";
        }
    }
}