using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSLib
{
    public class TwilioSmsSender : IMessageSender
    {
        
        public MessageResult SendMessage(string accountSid, string authToken, string sender, string recipient, string message)
        {
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(new PhoneNumber(recipient))
            {
                From = new PhoneNumber(sender),
                Body = message
            };

            var sentMessage = MessageResource.Create(messageOptions);

            var result = new MessageResult
            {
                Sid = sentMessage.Sid,
                Status = sentMessage.Status.ToString(),
                SentTime = sentMessage.DateSent,
                Response = sentMessage.Body
            };

            return result;

        }
    }
}