using System;
using ExMath.Coordinate;
using GamingServer.Gaming.Packet;

namespace GamingRoom.Gaming.Packet
{
    [Serializable]
    public class GamersPacket
    {
        public GamerPacket[] Gamers;

        public GamersPacket(int size)
        {
            Gamers = new GamerPacket[size];
        }
    }

    [Serializable]
    public class GamerPacket
    {
        public byte PlayerSlot;
         public int SkinID;
         public EGamerState State;
        public Vector3 HeadPos;
         public byte KillerID;
        public byte BackpackItem;
         public float BodyInterval;
         public float BodySizeRatio;
         public int DiamondValue;
         public int Length;
    }

    [Serializable]
    public class GamerIdentity
    {
        public byte PlayerID;
        public string SkinID;
        public string Name;
    }

    [Serializable]
    public class GamerIdentityGroup
    {
        public GamerIdentity myIdentity;
        public GamerIdentity[] others;
    }

    [Serializable]
    public class InitBody
    {
        public byte PlayerID;
        public Vector3[] Bodies;

        public InitBody(byte playerID, Vector3[] bodies)
        {
            PlayerID = playerID;
            Bodies = bodies;
        }
    }
}