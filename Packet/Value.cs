using System;

namespace GameServer
{
    public enum EClientLobbyCode
    {
        /// <summary>
        /// [1] Price.
        /// [2] ERoomType.
        /// [3] Access Token.
        /// [4] Name.
        /// [5] SkinID.
        /// [6] Icon.
        /// </summary>
        QuickJoin = 6,

        /// <summary>
        /// [1] RoomID.
        /// [3] Access Token.
        /// [4] Name.
        /// [5] SkinID.
        /// [6] Icon.
        /// </summary>
        JoinRoom = 7,

        PlayerReady = 10,

        LeaveRoom = 16,

        Register = 100,

        /// <summary>
        /// value: string(emoticon id).
        /// </summary>
        Emoticon = 120
    }

    /// <summary>
    /// For Client to send information to Server.
    /// </summary>
    public class ClientGameCode
    {
        public const byte DIRECTION = 10;      // 方向設定
        public const byte Rebirth = 12;
        public const byte SKILL = 14;      // 技能設定
        public const byte Item = 15;      // 道具使用
        public const byte INITIALIZE = 20;
        public const byte READY = 21;
        public const byte Leave = 22;

        public const byte Broadcast = 71;

        public const byte PureData = 150;
    }

    [Serializable]
    public enum EServerGameCode
    {
        Bonuspot = 2,

        Environment = 4,
        GameEvent = 5,
        GamerInfo = 6,

        /// <summary>
        /// Send all token and slot to client.
        /// Dictionary, key(string): token, value(byte): player slot.
        /// </summary>
        GamerSlots = 7,
        DropItem = 8,

        PacketNumber = 10,
        CountDown = 20,
        GameTime = 21,

        /// <summary>
        /// When: the peer is disconnected.
        /// byte[]: player slots.
        /// </summary>
        RMGamer = 32,

        Broadcast = 51,

        GoDebug = 101,

        PureData = 150,

        GameStart = 254,
        GameResult = 255
    }

    public static class GamingOperationCode
    {
        public const byte GameRoom = 30;
        public const byte GameLogic = 10;
    }
    
    [Serializable]
    public enum EServerLobbyCode
    {
        /// <summary>
        /// Notify Client that the waiting room can't join.
        /// </summary>
        RoomReady = 18,

        /// <summary>
        /// The waiting room is finished, the client is informed to load game scene.
        /// </summary>
        ToArena = 19,

        Rooms = 51,
        AllPeers = 52,

        Disconnect = 101   //重複帳號，通知前端登出
    }
    
    public enum EJoinRoomType : byte
    {
        Standard = 0,
        Practice = 1,
        Secret = 2,
        Game1,
        Game2,
        Train,
        // 測試用單機房
        DebugOffLine
    }
}