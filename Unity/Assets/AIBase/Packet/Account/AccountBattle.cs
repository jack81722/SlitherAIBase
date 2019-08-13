using System;
using System.Collections.Generic;
using static Values;

namespace SlitherEvo
{
    public class AccountBattle
    {
        //勝場紀錄
        public List<WinRecord> WinsRecord = new List<WinRecord>();
    }

    public class WinRecord
    {
        public DateTime ResultTime = DateTime.UtcNow;
        public ERoomType RoomType;
        public string SkinID;
        public int Rank;
        public int FinalResource;
    }
}