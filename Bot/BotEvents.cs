namespace GameServer
{
    public class BotEvents
    {
        public IPlayerIntput input;
        public IPlayerOutput output;

        public BotEvents(IPlayerIntput input, IPlayerOutput output)
        {
            this.input = input;
            this.output = output;
        }
    }
}