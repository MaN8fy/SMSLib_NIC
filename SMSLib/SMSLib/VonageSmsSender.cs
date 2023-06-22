using Vonage;
using Vonage.Request;

namespace SMSLib
{
    public class VonageSmsSender : IMessageSender
    {
        //implemention of SendMessage function for Vonage gateway.
        public MessageResult SendMessage(string apiKey, string apiSecret, string sender, string recipient, string message)
        {
            try {
                //initializing twilio API
                var vonageClient = new VonageClient(Credentials.FromApiKeyAndSecret(apiKey, apiSecret));

                //Sending SMS and declaring Sender, Recipient and SMS body
                var response = vonageClient.SmsClient.SendAnSms(new Vonage.Messaging.SendSmsRequest
                {
                    From = sender,
                    To = recipient,
                    Text = message
                });

                //Handling response
                var result = new MessageResult
                {
                    Id = response.Messages[0].MessageId,
                    Status = response.Messages[0].Status,
                    SentTime = "Unable to get",
                    MsgText = " - ", 
                    ErrorMsg = response.Messages[0].ErrorText,
                    Price = response.Messages[0].MessagePrice
                };
                return result;

            } catch {
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
