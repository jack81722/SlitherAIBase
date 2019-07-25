using System;

namespace FTServer.Projects.Slither.Packet
{
    [Serializable]
    public class Skill
    {
        [Serializable]
        public enum Category : byte
        {
            None, Jump, Dive, God ,SpeedUp,SpeedDown
        }
    }
}