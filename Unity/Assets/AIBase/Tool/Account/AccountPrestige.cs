namespace SlitherEvo
{
    public class AccountPrestige
    {
        public int Prestige;
        public GameLv StandardLv = new GameLv();
        public GameLv SecretLv = new GameLv();
    }


    //聲望等級
    public class GameLv
    {
        public int Lv = 1;
        public int Exp = 0;
        public int NextExp = 100;
    }
}