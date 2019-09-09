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

        private double maxTime = 1000;
        private double time = 0;

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
            time += span.TotalMilliseconds;
            if (time > maxTime)
            {
                //bot?.output.SendInput(Skill.Category.Jump);
                time = 0;
            }
            Console.WriteLine("Update");
        }
    }
}