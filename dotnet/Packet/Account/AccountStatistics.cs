namespace SlitherEvo
{
    public class AccountStatistics
    {
        public AccountLifetime Lifetime;
        public AccountWeek Week;
        public AccountDaily Daily;

        public class AccountLifetime
        {
            public int MaxSnakeLength; // 獲得過的最大長度
            public int MaxSurvivalTimeInSecond; // 存活最久時間.

            public int SumMVP; // MVP(第一名) 獲得次數.
            public int SumKillLength; // 總共獲得多少擊殺長度.
            public int SumPlayNum; // 總參戰次數.
            public int SumKillNum; // 總擊殺次數
        }

        public class AccountWeek
        {
            public int MaxSnakeLength; // 本周最大長度.
        }

        public class AccountDaily
        {
            public int MaxSnakeLength; // 當日蛇最長長度.
        }
    }
}