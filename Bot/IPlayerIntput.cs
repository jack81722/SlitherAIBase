using System;
using System.Collections.Generic;
using GameServer.Package;
using GamingRoom.Gaming.Packet;
using GamingRoom.Gaming.Room.GameLogic.DropSystem;
using GamingRoom.Gaming.Room.GameLogic.GameEventSystem;

namespace GameServer
{
    public interface IPlayerIntput
    {
        //SimWorld GetWorld();
        event Action<EnvironmentPacket> onReceiveEnvironment;
        event Action<GameEvent[]> onReceiveGameEvent;
        event Action<DropItemPacket> onReceiveDropItem;
        event Action<int> onReceiveBonuspot;
        event Action<GameResultPacket> onReceiveGameResult;
        event Action<GamersPacket> onReceiveGamerInfo;
        event Action<object> onReceiveBroadcast;
        event Action<string> onReceivePureData;
        event Action<object> onReceiveGameStart;
        event Action<Dictionary<string, byte>> onReceiveGamerSlots;
        event Action<byte[]> onReceiveRMGamer;
        event Action<int> onReceiveCountDown;
        event Action<float> onReceiveGameTime;
    }

    public class SimWorld
    {
        public EnvironmentPacket Environment;
        public GameEvent[] GameEvent;
        public DropItemPacket DropItem;
        public int Bonuspot;
        public GameResultPacket GameResult;
        public GamersPacket GamerInfo;
        public object Broadcast;
        public string PureData;
        public object GameStart;
        public Dictionary<string, byte> GamerSlots;
        public byte[] RMGamer;
        public int CountDown;
        public float GameTime;
    }
}