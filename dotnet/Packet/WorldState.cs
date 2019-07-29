using System;
using SlitherGame.Controller;

namespace GamingServer.Gaming.Packet
{
    /// <summary>
    ///世界狀態
    /// </summary>
    [Serializable]
    public class WorldState
    {
        public float GamingTime;
        public Gamer[] Gamers;
        public SceneObject SceneObject;
        public Command[] Commands;
    }
    [Serializable]
    public struct SceneObject
    {
        public Node[] Nodes;
    }
    [Serializable]
    public struct Node
    {
        public float[] Poition;
        public byte Category;
        public byte CMDState;
    }

    [Serializable]
    public struct Command
    {
        public byte PlayerId;
        public CommandCategory Category;
    }
    [Serializable]
    public enum CommandCategory : byte
    {
        QueryResourceRequest
    }

    /// <summary>
    /// 蛇
    /// </summary>
    [Serializable]
    public struct Gamer
    {
        public byte PlayerId; // 不可重複
        public byte HeroId;
        public EGamerState State;
        public Information_Position Information_position;
        public Information_Character Information_character;
        public int DiamondValue;
        public float NodeLength;
        public byte KillerID;//兇手ID 0~20一般玩家  255沒兇手  254毒圈或牆壁
    }

    [Flags, Serializable]
    public enum EGamerState : byte
    {
        None = 0,
        Die = 1,
        Jump = 2,
        Invisible = 4,
        Invisible2 = 5,
        SpeedUp = 8,
        God = 16
    }

    [Flags, Serializable]
    public enum skillState : byte
    {
        neuter = 0,
        nFoggy = 1,
        nEarthquark = 2,
        nNatureShell = 4,
        bLightingPulse = 8,
        nLightingPulse = 16,
        bHolyBall = 32,
        bSneak = 64
    }
    [Serializable]
    public struct Information_Position
    {
        public float[] Position;
        public Direction.D32 Rotation; //32 方位 ( 0 ~ 31 )
    }
    [Serializable]
    public struct Information_Character
    {
        public float MoveSpeed;
        public float RotateSpeed;
        public float[] SkillCd;
        public float Range;
        public SubBody Body;
    }
    [Serializable]
    public struct SubBody
    {
        public float NodeDistance;
        public Body[] Nodes;
        public float Collider_Radius;
    }
    [Serializable]
    public struct Body
    {
        public float[] Position;
    }
}
