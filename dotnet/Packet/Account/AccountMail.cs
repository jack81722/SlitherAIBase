using System;
using System.Collections.Generic;

namespace SlitherEvo
{
    public class AccountMail
    {
        public List<Mail> NewList = new List<Mail>();
        public List<Mail> ClaimedList = new List<Mail>();
    }

    public class Mail
    {
        public string Sender;
        public string Gist;
        public string Text;

        public int Gold;
        public int Diamond;
        public int Ticket;

        public DateTime SendTime;

        public Dictionary<string, int> Items = new Dictionary<string, int>();
        public Dictionary<string, int> Fragments = new Dictionary<string, int>();
    }
}