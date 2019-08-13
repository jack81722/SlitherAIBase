using System;
using GamingRoom.Gaming.Packet;

namespace GameServer.Packet
{
    [Serializable]
    public class EnterArenaPacket
    {
        public int Slot;
        public GamerPacket[] Gamers;

        public override string ToString()
        {
            return $"Slot:{Slot}, GamersNum:{Gamers.Length}";
        }
    }
}