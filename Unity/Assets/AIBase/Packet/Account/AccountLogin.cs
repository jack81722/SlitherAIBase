using System;

namespace SlitherEvo
{
    public class AccountLogin
    {
        public DateTime LoginTime;
        public DateTime CreatedTime;
        
        public int MonthRewardDay;

        public DateTime ClaimDailyRewardTime;

        public bool HasDailyReward =>
            DateTime.UtcNow > ClaimDailyRewardTime;

        public DateTime ClaimNightRewardTime;

        // 宣告 限時獎勵開始時間
        public readonly int NightStartHour = 20;
        // 宣告 限時獎勵結束時間
        public readonly int NightEndHour = 22;
        // 限時 獎勵狀態
        public enum EHasNightReward
        {
            // 可以領取
            CanClaim,
            // 現在不是活動時間
            NotActiveTime,
            // 已領取
            Received
        }
        public EHasNightReward HasNightReward
        {
            get
            {
                // 取得 本機時間
                var now = DateTime.Now;
                // 取得 可領取的時間
                var claimTime = ClaimNightRewardTime.ToLocalTime();
                // 取得 是否是隔天
                var isNextDay = now.Year > claimTime.Year ||
                                now.Month > claimTime.Month ||
                                now.Day > claimTime.Day;
                // 如果 不是隔天才可以領取
                if (!isNextDay)
                {
                    // 回傳 已領取
                    return EHasNightReward.Received;
                }
                // 取得 是否是在可以領取的時間
                var isInTimeRange = NightStartHour <= now.Hour && 
                                    now.Hour <= NightEndHour;
                // 如果 不是在可以領取的時間
                if (!isInTimeRange)
                {
                    // 回傳 現在不是活動時間
                    return EHasNightReward.NotActiveTime;
                }
                // 回傳 可以領取
                return EHasNightReward.CanClaim;
            }
        }

        public DateTime AssetRewardIDResetTime;
        public int ClaimAssetRewardID;

        public bool HasNewYearReward
        {
            get { return false; }
        }

        public DateTime ClaimNewYearRewardTime;
    }
}