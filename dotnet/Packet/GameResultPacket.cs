using System;

namespace GameServer
{
    [Serializable]
    public class GameResultPacket
    {
        public GamerResultPacket[] Gamers;
        public int BonusValue;
    }

    [Serializable]
    public class GamerResultPacket
    {
        public byte PlayerSlot;   
        public int Stake;         
        public int CostDiamond; // 花費鑽石數
        public int Score;
    }
}