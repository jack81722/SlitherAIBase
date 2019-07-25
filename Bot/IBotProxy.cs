using SlitherEvo;

namespace GameServer
{
    public interface IBotProxy
    {
        void GameStart(Account account,byte slotId,BotEvents bot);

        void GameUpdate();
    }
}