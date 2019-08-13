using System;

namespace GameServer.Package
{
    [Serializable]
    public struct EnvironmentPacket
    {
        //        public bool UpdateObstacle;
        public float Boundary;
        //        public ObstacleData[] obstDatas;
    }

    //    [Serializable]
    //    public struct ObstacleData
    //    {
    //        public uint id;
    //        public GeoShape shape;
    //        public Vector3 position;
    //        public Vector3 scale;
    //    }
    //
    //    [Serializable]
    //    public enum GeoShape
    //    {
    //        Cube = 1,
    //        Sphere = 2
    //    }
}