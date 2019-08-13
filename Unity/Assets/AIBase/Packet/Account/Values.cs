using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class Values
{
    public static readonly string LOBBY_VERSION_INFO = "0.9.5 v";
    public const float PLAYER_SPEED = 1f;
    public const string ACCOUNT_ID = "TEST01";
    // 是否 可以使用 Secret
    public const bool CanUseSecretBinding = true;
    // 是否 要使用測試版的 Secret 下載網址
    public const bool IsUseSecretBetaDownloadURL = false;

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EQueryString
    {
        Refresh
    }

    public enum EEventType
    {
        Follow = 0,
        Thumb = 1
    }

    public enum EEventStatus
    {
        IFollowWho = 0,//我關注誰
        WhoFollowI = 1,//誰關注我
        MutualFollow = 2//互相關注
    }

    public enum ERoomType
    {
        Standard = 0,
        Practice = 1,
        Secret = 2,
        Game1 = 3,
        Game2 = 4
    }

    //通緝等級
    public enum EPostRewardLevel
    {
        God = 0,
        Dragon = 1,
        Ghost = 2,
        Tiger = 3,
        Wolf = 4
    }

    public enum EFriendParam
    {
        Add = 0,
        Delete = 1
    }

    public enum EDailyMissionType
    {
        PlayNormal,
        EatSmall,
        EatBig,
        CollectDiamond,
        CollectItem
    }

    public enum EPlayerListType
    {
        Revenge,
        Friend,
        GetPostRewardRecord,
        WhoPostMeReward
    }

    public enum ERankMode
    {
        Null = 0,
        Diamond = 1,
        Ruby = 2,
        Event = 3,
        SumKillNums = 4,
        SurvivalTime = 5
    }

    public enum ESortMode
    {
        Null,
        desc, //從大到小
        asc //從小到大
    }

    public enum ETimeMode
    {
        Null,
        Daily,
        Weekly,
        Monthly,
        Total
    }

    public enum EAchievement
    {
        StandardLv,
        SecretLv
    }

    public class SCENE_NAME
    {
        public const string Logo = "Scene_Logo";
        public const string MainMenu = "Scene_Loading";
        public const string Lobby = "Scene_Lobby_Original";
        public const string Opening = "Scene_Opening";
        public const string GamePlay_H_M201 = "GamePlay_H_M201";
    }

    // UI 的場景
    public class UI_SCENE_NAME
    {
        public const string Lobby = "Scene_Lobby";
        public const string Shop = "Scene_Shop";
        public const string Treasure = "Scene_Treasure";
        public const string WaittingRoom = "Scene_WaittingRoom";
    }

    //public static CWEB_ROOM_NAME WEB_ROOM_Text_NAME = new CWEB_ROOM_NAME();

    public class WEB_ROOM_NAME
    {
        // 需要 透過 LocalizationLgg 的 GetText 方法來取得本地化的名稱
        public const string Stage0 = "Values_ROOM_NAME_Stage_001";
        public const string Stage1 = "Values_ROOM_NAME_Stage_002";
        public const string Stage2 = "Values_ROOM_NAME_Stage_003";
        public const string Stage3 = "Values_ROOM_NAME_Stage_004";
        public const string Stage4 = "Values_ROOM_NAME_Stage_005";
        public const string Stage5 = "Values_ROOM_NAME_Stage_006";
        public const string Stage6 = "Values_ROOM_NAME_Stage_007";
        public const string Stage7 = "Values_ROOM_NAME_Stage_008";
        public const string Stage8 = "Values_ROOM_NAME_Stage_009";
    }

    //public class WEB_ROOM_PRICE
    //{
    //    public const int PRICE0 = 10;
    //    public const int PRICE1 = 100;
    //    public const int PRICE2 = 1000;
    //    public const int PRICE3 = 10000;
    //    public const int PRICE4 = 100000;
    //    public const int PRICE5 = 10000;
    //    public const int PRICE6 = 50000;
    //    public const int PRICE7 = 100000;
    //    public const int PRICE8 = 1000000;
    //}

    public class ASSET_BUNDLE
    {
        public const string SYSTEM_DESIGN = "SystemDesign";
        public const string UI_OTHER = "UI_Other";
        public const string CHARACTER = "Character";
    }
}