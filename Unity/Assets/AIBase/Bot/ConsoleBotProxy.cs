using System;
using FTServer.Projects.Slither.Packet;
using GamingRoom.Gaming.Packet;
using GamingServer.Gaming.Packet;
using SlitherEvo;

namespace GameServer
{
    public class ConsoleBotProxy : IBotProxy
    {
        private byte slotId;
        private Account account;
        private BotEvents bot;

        public void GameStart(Account account,byte slotId,BotEvents bot)
        {
            this.account = account;
            this.slotId = slotId;
            this.bot = bot;
            bot.input.onReceiveGamerInfo += InputOnOnReceiveGamerInfo;
        }

        private void InputOnOnReceiveGamerInfo(GamersPacket gamersPacket)
        {
            //auto rebrith
            for (int i = 0; i < gamersPacket.Gamers.Length; i++)
            {
                if (gamersPacket.Gamers[i].PlayerSlot == slotId &&
                    gamersPacket.Gamers[i].State == EGamerState.Die)
                {
                    bot.output.Rebirth(0);
                }
            }
        }

        public void GameUpdate(TimeSpan span)
        {
            bot?.output.SendInput(Skill.Category.Jump);
        }
    }
}