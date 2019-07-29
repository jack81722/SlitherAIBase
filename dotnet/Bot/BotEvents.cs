namespace GameServer
{
    public class BotEvents
    {
        public IPlayerInput input;
        public IPlayerOutput output;

        public BotEvents(IPlayerInput input, IPlayerOutput output)
        {
            this.input = input;
            this.output = output;
        }
    }
}