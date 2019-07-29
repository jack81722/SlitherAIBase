using System;

namespace SlitherGame.Controller
{
    [Serializable]
    public class Direction
    {
        [Serializable]
        public enum D32 : byte
        {
            E, EbN, ENE, NEbE, NE, NEbN, NNE, NbE,
            N, NbW, NNW, NWbN, NW, NWbW, WNW, WbN,
            W, WbS, WSW, SWbW, SW, SWbS, SSW, SbW,
            S, SbE, SSE, SEbS, SE, SEbE, ESE, EbS
        }

        public static float GetAngle(Direction.D32 d32)
        {
            return (byte)d32 * 11.25f;
        }

        public static Direction.D32 GetD32(float eular)
        {
            byte b = (byte)System.Math.Round(eular / 11.25);
            if (b >= 32)
                b %= 32;
            return (D32)b;
        }
    }
}