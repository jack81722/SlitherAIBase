using System;

namespace GameServer
{
    [Serializable]
    public class QuickJoinInput
    {
        public int Price;
        public byte RoomType;
        public string Token;
        public string Name;
        public string SkinID;
    }
}