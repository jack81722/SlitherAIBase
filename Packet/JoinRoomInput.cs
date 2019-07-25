using System;

namespace GameServer
{
    [Serializable]
    public class JoinRoomInput
    {
        public int RoomID;
        public string Token; 
        public string Name;
        public string SkinID;
    }
}