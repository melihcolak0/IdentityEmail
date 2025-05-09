namespace _02PC_IdentityChatEmail.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        public string SenderMail { get; set; }

        public string ReceiverMail { get; set; }

        public string Subject { get; set; }

        public string MessageDetail { get; set; }

        public bool IsRead { get; set; }

        public DateTime SendDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
