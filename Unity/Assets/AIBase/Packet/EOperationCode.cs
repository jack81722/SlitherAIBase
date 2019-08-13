namespace GameServer
{
    public enum EOperationCode : byte
    {
        Gaming = 2,
        Lobby = 7,
        ToArena = 8,
        GameLogic = 10,
        GameRoom = 30,
        Error = 255
    }
}