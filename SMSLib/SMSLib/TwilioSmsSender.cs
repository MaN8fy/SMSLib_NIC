using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSLib
{
    public class TwilioSmsSender : IMessageSender
    {
        
        public void SendMessage(string accountSid, string authToken, string sender, string recipient, string message)
        {
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(new PhoneNumber(recipient))
            {
                From = new PhoneNumber(sender),
                Body = message
            };

            var sentMessage = MessageResource.Create(messageOptions);

        }
    }
}