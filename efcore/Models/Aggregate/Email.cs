namespace EFCore.Models.Aggregate
{
    public class Email
    {
        internal Email(string emailString, EmailType type, EmailStatus status)
        {
            EmailString = emailString;
            Type = type;
            Status = status;
        }

        public string EmailString { get; set; }

        public EmailType Type { get; set; }

        public EmailStatus Status { get; set; }
    }
}