using System;
using System.Collections.Generic;
using System.Linq;
using static Values;

namespace SlitherEvo
{
    public class AccountMission
    {
        public DateTime targettime = new DateTime();
        public int totalvalue;
        public int DailyMissionBouns;
        public bool IsDailyMissionBounsReceived;
        public List<Mission> DailyMissionList = new List<Mission>();

        /// <summary>
        /// 取得活動期間總累積數量
        /// </summary>
        /// <param name="missionindex"></param>
        /// <returns></returns>
        public int GettotalValueByIndex()
        {
            return totalvalue;
        }

        /// <summary>
        /// 取得今日目前累積數量
        /// </summary>
        /// <param name="missionindex"></param>
        /// <returns></returns>
        public int GetNowValueByIndex(int missionindex)
        {
            return DailyMissionList[missionindex].nowvalue;
        }

        /// <summary>
        /// 取得尚未領取獎勵的TargetValue
        /// </summary>
        /// <param name="missionindex"></param>
        /// <returns></returns>
        public int GetTargetValueByIndex(int missionindex)
        {
            return DailyMissionList[missionindex].targetvalue;
        }

        public int GetNowStep(int missionindex)
        {
            if (DailyMissionList[missionindex].IsLv2Received) return 3;
            else if (DailyMissionList[missionindex].IsLv1Received) return 2;
            else return 1;
        }

        /// <summary>
        /// 取得可領獎勵
        /// </summary>
        /// <param name="missionindex"></param>
        /// <returns></returns>
        public int GetRewardByIndex(int missionindex)
        {
            if (DailyMissionList[missionindex].IsLv2Received)
                return DailyMissionList[missionindex].Lv3reward;

            else if(DailyMissionList[missionindex].IsLv1Received)
                return DailyMissionList[missionindex].Lv2reward;

            else return DailyMissionList[missionindex].Lv1reward;
        }

        public bool GetAllReceivedByIndex(int missionindex)
        {
            if (DailyMissionList[missionindex].IsLv3Received) { return true; }
            else { return false; }
        }

        public Mission GetmissionByIndex(int missionindex)
        {
            return DailyMissionList[missionindex];
        }
    }

    public class Mission
    {
        public EDailyMissionType DailyMissiontype;
        public bool IsLv1Received;
        public bool IsLv2Received;
        public bool IsLv3Received;
        public int nowvalue;
        public int targetvalue;
        public int Lv1reward;
        public int Lv2reward;
        public int Lv3reward;
        public int reward;
        public bool IsReceived;
    }
}