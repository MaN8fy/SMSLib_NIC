using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SMSLib
{
    public class TwilioSmsSender : IMessageSender
    {  
        //implemention of SendMessage function for twilio gateway
        public MessageResult SendMessage(string apiKey, string apiSecret, string sender, string recipient, string message)
        {
            try
            {
                //initializing twilio API
                TwilioClient.Init(apiKey, apiSecret);

                //Sender, Recipient and SMS body
                var messageOptions = new CreateMessageOptions(new PhoneNumber(recipient))
                {
                    From = new PhoneNumber(sender),
                    Body = message
                };

                //sending message
                var sentMessage = MessageResource.Create(messageOptions);

                //handling response
                var result = new MessageResult
                {
                    Id = sentMessage.Sid,
                    Status = sentMessage.Status.ToString(),
                    SentTime = sentMessage.DateSent.ToString(),
                    MsgText = sentMessage.Body,
                    ErrorMsg = sentMessage.ErrorMessage,
                    Price = sentMessage.Price
                };
                return result;

            } catch
            {
                var result = new MessageResult
                {
                    Status = "Failed",
                    ErrorMsg = "Something went wrong. Check all the parameters you are passing through."
                };

                return result;
            }
        }
    }
}