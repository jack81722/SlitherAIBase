using System;

namespace SocketServer.ProcessChain
{
    [Serializable]
    public class Response
    {
        public const int Unknown = 0;
        public const int Okey = 1;
        public const int ConditionFail = 2;

        public int Code;
        public string Msg;

        public bool IsOk => Code == Okey;

        public Response()
        {
            Code = 1;
            Msg = "OK";
        }

        public Response(int code, string message)
        {
            Code = code;
            Msg = message;
        }

        public override string ToString()
        {
            return $"Code : {Code}, Msg : {Msg}";
        }
    }

    public class ResponseException : Exception
    {
        public int Code;

        public ResponseException(Response response) : base(response.Msg) { }

        public ResponseException(int code, string message) : base(message) { }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Code)}: {Code}, Message:{Message}";
        }
    }

}
