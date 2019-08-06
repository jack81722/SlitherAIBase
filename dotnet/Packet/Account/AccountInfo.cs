namespace SlitherEvo
{
    public class AccountInfo
    {
        public string Name;
        public int ChangeNameTicket;

        public string FrameIcon;
        public string Icon;

        public int Ruby;
        public int Diamond;
        public int Gold;
        public int Ticket;

        public bool IsTutorialDone;

        public ETitle Title;
        public int Lv = 1;
        public int Exp;

        public bool IsBan;

        public ESex Sex;
        public string Country;

        public int TreasurePoint;
    }
    public enum ETitle { _0Nothing, _1Bronze, _2Silver, _3Gold, _4Platinum, 
        _5Diamond, _6Master, _7Legend }
}