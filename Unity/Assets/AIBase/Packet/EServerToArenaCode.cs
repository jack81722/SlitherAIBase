using System;

namespace GameServer
{
    [Serializable]
    public enum EServerToArenaCode : byte
    {
        /// <summary>
        /// The waiting room is finished, the client is informed to enter arena.
        /// </summary>
        EnterArena = 1,
        DeleteArenaPlayers = 2,
        StartGame = 3,
        KickOff = 4
    }
}