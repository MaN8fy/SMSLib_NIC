namespace SMSLib
{
    public interface IMessageSender
    {
        void SendMessage(string accountSid, string authToken, string sender, string recipient, string message);
    }
}
