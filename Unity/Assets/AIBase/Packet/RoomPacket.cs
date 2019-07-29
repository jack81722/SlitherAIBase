using System;

namespace GameServer
{
    [Serializable]
    public struct RoomPacket
    {
        public byte Type;
        public int ID;
//        public int WaterID;
        public int Price;
        public int CurrPlayerCount;
        public int MaxPlayerCount;
        public string RoomNumber => $"No.{ID}";

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(Price)}: {Price}, " +
                   $"{nameof(CurrPlayerCount)}: {CurrPlayerCount}, {nameof(MaxPlayerCount)}: {MaxPlayerCount}";
        }
    }
}