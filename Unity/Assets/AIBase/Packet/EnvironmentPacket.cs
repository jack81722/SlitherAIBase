using System;
using ExMath.Coordinate;

namespace GameServer.Package
{
    [Serializable]
    public struct EnvironmentPacket
    {
//        public bool updateBoundary;
        public bool updateObstacle;
        public float boundary;
        public ObstacleData[] obstDatas;
    }

    [Serializable]
    public struct ObstacleData
    {
        public uint id;
        public GeoShape shape;
        public Vector3 position;
        public Vector3 scale;
    }

    [Serializable]
    public enum GeoShape
    {
        Cube = 1,
        Sphere = 2
    }
}