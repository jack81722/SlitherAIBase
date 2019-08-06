
using System;

namespace SlitherEvo
{
    public class Account
    {
        public AccountLogin Login;
        public AccountInfo Info;
        public AccountPrestige Prestige;
        public AccountSnake Snake;
        public AccountItems Items;
        public AccountOnSale OnSale;
        public AccountMail Mail;
        public AccountStatistics Statistics;
        public AccountEvent Event;
        public AccountMission DailyMission;
        public AccountBattle Battle;
        public string DeviceID;

        public bool HasLoginReward => Login.HasDailyReward || (Login.HasNightReward == AccountLogin.EHasNightReward.CanClaim) || 
                                      HasLoginReward;

        public bool HasAssetReward
        {
            get { return false; }
        }

        public override string ToString() { return $"Name:{Info.Name}"; }
    }

    public enum ESex
    {
        Male = 0, Female = 1
    }
}