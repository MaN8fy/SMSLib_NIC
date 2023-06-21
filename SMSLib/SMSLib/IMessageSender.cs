using System;

namespace SMSLib
{
    public interface IMessageSender
    {
        MessageResult SendMessage(string accountSid, string authToken, string sender, string recipient, string message);
    }

    public class MessageResult
    {
        public string Sid { get; set; }
        public string Status { get; set; }
        public DateTime? SentTime { get; set; }
        public string Response { get; set; }
        public string ErrorMsg { get; set; }
    }
}
