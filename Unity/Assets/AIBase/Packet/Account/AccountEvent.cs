using System.Collections.Generic;

namespace SlitherEvo
{
    public class AccountEvent
    {
        public HashSet<int> ClaimedTask = new HashSet<int>();
        public List<Event> Now = new List<Event>();

        public class Event
        {
            public int ID;

            public int SumKill;
            public int SumMVP;

            public Event(int id) { ID = id; }
        }
    }
}