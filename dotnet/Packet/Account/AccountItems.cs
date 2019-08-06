using System.Collections.Generic;

namespace SlitherEvo
{
    public class AccountItems
    {
        public Dictionary<string, int> IDNums = new Dictionary<string, int>();
        public string UseItemID;

        public const string ReviveTicketID = "E021";

        public int ReviveTicketNum => GetByID(ReviveTicketID);

        public bool HasByID(string itemID)
        {
            if(string.IsNullOrEmpty(itemID))
                return false;

            return IDNums.ContainsKey(itemID);
        }

        public int GetByID(string id)
        {
            if(IDNums.ContainsKey(id))
                return IDNums[id];
            return 0;
        }

        public int Count => IDNums.Count;

        public void Clear() { IDNums.Clear(); }
    }
}