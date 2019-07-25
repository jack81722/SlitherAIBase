using System;

namespace GameServer.Packet
{
    [Serializable]
    public enum ECode
    {
        Unknown = 0,
        Ok = 1,

        UserServerError = 2001,
        SystemError = 2002,
        SystemError_UnSupportCurrency = 2003,

        AuthenticationFail = 2010,

        Expired = 2020,
        Ban = 2021,

        Error_TutorialDone = 2031,

        InputError = 2100,
        InputError_AccountDoNotExist = 2101,
        InputError_DoNotHasAnyNewMail = 2102,
        InputError_MailIndex = 2103,

        InputError_LackTreasurePoint = 2150,
        InputError_LackAlmightyFragment = 2151,
        InputError_LackFragment = 2152,
        InputError_LackDiamond = 2153,
        InputError_LackRuby = 2154,
        InputError_LackResource = 2155,
        InputError_LackReviveTicket = 2156,
        InputError_LackReviveTicketNums = 2157,

        InputError_SkinID = 2170,
        InputError_SkinIDOwnByUser = 2171,
        InputError_ShopIDIllegal = 2172,
        InputError_ProductIDDifference = 2173,
        InputError_ProductIDIllegal = 2174,
        InputError_AppleReceipt = 2175,
        InputError_AppleOrderUsed = 2176,
        InputError_AppleTransactionState = 2177,
        InputError_OrderIDEmpty = 2178,
        InputError_GoogleOrderUsed = 2179,
        InputError_SnakeID=2180,

        InputError_EntranceFee = 2190,
        InputError_RoomType = 2191,
        InputError_Rebirth = 2192,
        InputError_PlayerToken = 2193,
        InputError_RoomID = 2194,
        InputError_SunKillNum = 2195,
        InputError_PlayerKillPlayerNum = 2196,
        InputError_Rank = 2197,
        InputError_Room = 2198,
        InputError_AddDiamond = 2199,
        InputError_AddTicket = 2200,
        InputError_AddTreasurePoint = 2201,
        InputError_KillNum = 2202,
        InputError_Player = 2203,
        InputError_Price = 2204,

        InputError_Filename = 2210,

        InputError_SecretDoNotBinding = 2300,

        InAppPurchaseCheckInvoiceError = 2400,

        InputError_AlreadyReceivedDailyReward=2500,
        InputError_AlreadyReceivedDailyBonus = 2501,
        InputError_NotReachGoal = 2502,
        NotActivityTime = 3000,

        InputError_Followed = 3500,
        InputError_EmptyList = 3501,
        InputError_NotFollow = 3502,

        PACKET_ERROR = 5001,

        DEV_ID_ERROR       = 5500,
        CREATE_ROOM_FAIL   = 5520,
        NOT_FOUND_ROOM     = 5521,
        JOIN_ROOM_FAIL     = 5530,
        QUICK_JOIN_FAIL    = 5531,
        NO_JOIN_ROOM       = 5532,
        UNKOWN_ROOM_TYPE   = 5533,
        NO_AVAILABLE_SLOT  = 5534,
        SLOT_ERROR         = 5535,
        EXIT_ROOM_FAIL     = 5590,

        ILLEGAL_TIME       = 5600,
        ILLEGAL_STATE      = 5601,
        ILLEGAL_FORMAT     = 5602,
        REVIVE_CD          = 5700,
        WAIT_START_INIT    = 5800,
        GAME_NOT_END       = 5900,
        CALCULATE_RESULT   = 5901,

        USER_NOT_FOUND     = 6000,
        USER_NO_RESPONSE   = 6001,
        FORMAT_NOT_MATCH   = 6010,
        INVALID_INPUT      = 6020
    }
}
