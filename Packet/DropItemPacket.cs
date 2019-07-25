using ExMath.Coordinate;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamingRoom.Gaming.Room.GameLogic.DropSystem
{
    [Serializable]
    public class DropItemPacket
    {
        public DropItemData[] all;
        public DropItemData[] added;
        public uint[] removed;
        public Vector3[] spawnPoses;
        public uint[][] spawnIDs;
    }

    [Serializable]
    public class DropItemData
    {
        public uint id;
        public ItemType type;
        public Vector3 position;

        public DropItemData(uint id, ItemType type, Vector3 position)
        {
            this.id = id;
            this.type = type;
            this.position = position;
        }
    }

    [Serializable]
    public enum ItemType : byte
    {
        SmallFood,
        BigFood,
        Diamond,
        RandomBox,
    }
}