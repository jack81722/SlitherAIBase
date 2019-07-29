using System;

namespace GamingRoom.Gaming.Room.GameLogic.GameEventSystem
{
    [Serializable]
    public class GameEvent
    {
        public byte eventCode;
    }

    [Serializable]
    public class GameEventCode
    {
        public const byte BATTLE = 0;
        public const byte BOUNCE = 1;
    }

    [Serializable]
    public class BattleEvent : GameEvent
    {
        public byte winner;
        public byte loser;

        public BattleEvent(byte winner, byte loser)
        {
            eventCode = GameEventCode.BATTLE;
            this.winner = winner;
            this.loser = loser;
        }
    }

    [Serializable]
    public class BounceEvent : GameEvent
    {
        public uint obstacleID;

        public BounceEvent(uint id)
        {
            eventCode = GameEventCode.BOUNCE;
            obstacleID = id;
        }
    }
}