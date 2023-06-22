namespace SMSLib
{
    //Interface for sending a message.
    public interface IMessageSender
    {
        MessageResult SendMessage(string apiKey, string apiSecret, string sender, string recipient, string message);
    }

    //Class that stores message results.
    public class MessageResult
    {
        public string Id { get; set; } //ID of message
        public string Status { get; set; } //Status of message (sent, delivered, failed, etc.) 
        public string SentTime { get; set; } //Time that message wasa sent
        public string MsgText { get; set; } //Body of message
        public string ErrorMsg { get; set; } //If message failed, here is why
        public string Price { get; set; } //Price of a message
    }
}
