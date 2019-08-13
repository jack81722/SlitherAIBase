using System;

namespace GameServer
{
    [Serializable]
    public enum EClientToArenaCode : byte
    {
        LoadingPercent = 1,
        Ready = 2
    }
}