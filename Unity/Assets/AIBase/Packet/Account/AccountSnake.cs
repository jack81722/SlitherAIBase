using System.Collections.Generic;

namespace SlitherEvo
{
    public class AccountSnake
    {
        public AccountSkin Skin = new AccountSkin();
        // key: Skin type(SnakeTable.Row.Type), value: play numbers.
        public Dictionary<string, int> SkinPlayNums = new Dictionary<string, int>();

        #region Method GetSkinPlayNums
        // 取得 遊玩次數 (蛇的類型)
        public int GetSkinPlayNums(string snakeType)
        {
            // 如果 有資料
            if (SkinPlayNums.ContainsKey(snakeType))
            {
                // 設定 次數
                return SkinPlayNums[snakeType];
            }
            // 如果 沒有
            else
            {
                // 設定 次數
                return 0;
            }
        }
        #endregion

        // key: Skin type(SnakeTable.Row.Type), value: kill numbers.
        public Dictionary<string, int> SkinKillNums = new Dictionary<string, int>();

        #region Method GetSkinKillNums
        // 取得 擊殺次數 (蛇的類型)
        public int GetSkinKillNums(string snakeType)
        {
            // 如果 有資料
            if (SkinKillNums.ContainsKey(snakeType))
            {
                // 設定 次數
                return SkinKillNums[snakeType];
            }
            // 如果 沒有
            else
            {
                // 設定 次數
                return 0;
            }
        }
        #endregion
        
    }

    public class AccountSkin
    {
        public string EquipID = string.Empty;
        public List<SnakeData> SnakeData = new List<SnakeData>();
        // ReSharper disable once InconsistentNaming
        public List<string> IDs = new List<string>();
        public List<string> AlreadyEquipedIDs = new List<string>();

        public bool IsAlreadyEquiped(string ID)
        {
            if (AlreadyEquipedIDs.Contains(ID)) { return true; }
            else return false;
        }

        public bool HasSkin(string skinID) { return IDs.Contains(skinID); }
        private readonly List<string> mTempIDs = new List<string>();
        public List<string> GetIDs()
        {
            mTempIDs.Clear();
            mTempIDs.AddRange(IDs);
            return mTempIDs;
        }

        public SnakeData GetHeroByTypeId(string typeid)
        {
            var snakedata = SnakeData.Find(x => x.TypeID == typeid);
            return snakedata;
        }

        public int GetHeroLvByTypeId(string typeid)
        {
            var snakedata = GetHeroByTypeId(typeid);
            if (snakedata == null) { return 1; }
            return snakedata.Lv;
        }

        public int GetHeroExpByTypeId(string typeid)
        {
            var snakedata = GetHeroByTypeId(typeid);
            if (snakedata == null) { return 0; }
            return snakedata.Exp;
        }

        // key: Snake ID, value:
        public Dictionary<string, int> Fragments = new Dictionary<string, int>();

        public bool HasTransformableFragment()
        {
            foreach(var pair in Fragments)
            {
                var skinID = pair.Key;
                var num = pair.Value;

                if(HasSkin(skinID) && num > 0)
                    return true;
            }

            return false;
        }

        public int GetFragment(string id)
        {
            if(Fragments.ContainsKey(id))
                return Fragments[id];
            return 0;
        }

        public string ModelName
        {
            get { return "S001"; }
        }
    }

    public class SnakeData
    {
        public string TypeID;
        public string DefaultSkinID;
        public Dictionary<string, string> EquipID = new Dictionary<string, string>();
        public int Lv;
        public int Exp;
        public int NextLevelExp;
        public Dictionary<string, string> Skill = new Dictionary<string, string>();
        public int Agility;
        public int Initiallength;
        public double Basespeed;
        public int Appetite;
    }

    public class UnlockMission
    {
        public string SkinID = string.Empty;
        public int NowValue = 0;
        public int TargetValue = 0;
    }
}