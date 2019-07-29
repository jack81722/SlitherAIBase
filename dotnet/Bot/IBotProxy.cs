using SlitherEvo;
using System;

namespace GameServer
{
    public interface IBotProxy
    {
        void GameStart(Account account,byte slotId, BotEvents bot);

        void GameUpdate(TimeSpan time);
    }
}