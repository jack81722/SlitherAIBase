using System;

namespace FTServer.Projects.Slither.Packet
{
    [Serializable]
    public enum OperatorCode : byte
    {
        Snake,
    }
    [Serializable]
    public class Base
    {
        public OperatorCode Code = OperatorCode.Snake;
    }
    /// <summary>
    /// 測試用資料
    /// </summary>
    [Serializable]
    public class Test
    {
        public string Text = "";
    }
    /// <summary>
    /// 開始排隊時，傳入的資料
    /// </summary>
    [Serializable]
    public class QueueInfo
    {
        public string Key, DeviceID;
    }
    /// <summary>
    /// 排完隊的回傳
    /// </summary>
    [Serializable]
    public class JoinQueueResponse
    {
        public byte PlayerId = 0;
        public bool Success = false;
    }

    [Serializable]
    public class SnakePacket : Base
    {
        public byte PlayerId;
        public float[] Position;
        public float Rotation;
    }

    [Serializable]
    public struct PlayerPacket
    {
        public int SlotID;     // 玩家座位ID
        public string SkinID;  // 角色皮膚
        public string Name;    // 玩家名稱
        public string Icon;    // 玩家頭像
        public bool IsReady;    // 是否快速出發
    }
}