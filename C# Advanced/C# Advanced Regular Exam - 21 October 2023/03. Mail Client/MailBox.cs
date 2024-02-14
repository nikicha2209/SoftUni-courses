using System.Runtime.InteropServices;
using System.Text;

namespace MailClient
{
    public class MailBox
    {
        public int Capacity { get; set; }
        public List<Mail> Inbox { get; set; }
        public List<Mail> Archive { get; set; }

        public MailBox(int capacity)
        {
            Capacity = capacity;
            Inbox = new List<Mail>();
            Archive = new List<Mail>();
        }

        public void IncomingMail(Mail mail)
        {
            if (Inbox.Count < Capacity)
            {
                Inbox.Add(mail);
            }
        }

        public bool DeleteMail(string sender)
        {
            Mail found = Inbox.FirstOrDefault(mail => mail.Sender == sender);
            if (found != null)
            {
                Inbox.Remove(found);
                return true;
            }

            return false;
        }

        public int ArchiveInboxMessages()
        {
            int count = Inbox.Count;
            Archive.AddRange(Inbox);
            Inbox = new List<Mail>();
            return count;
        }

        public string GetLongestMessage()
        {
            return Inbox.OrderByDescending(mail => mail.Body.Length).FirstOrDefault().ToString();

        }

        public string InboxView()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Inbox:");
            foreach (Mail mail in Inbox)
            {
                sb.AppendLine(mail.ToString().TrimEnd());
            }

            return sb.ToString().TrimEnd();
        }
    }
}