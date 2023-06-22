# SMSLib Dokumentace

## Po�adavky

.NET 5.0 or above, .NET Standard 2.0 or above.

## Struktura

### interface - IMessageSender

Rozhran� ***IMessageSender*** definuje funkci SendMessage, kter� slou�� k odesl�n� zpr�vy.

Tato funkce p�ij�m� 5 parametr�:

- `apiKey` - ID ��tu
- `apiSecret` - autentifika�n� token
- `sender` - ��slo odes�latele
- `recipient` - ��slo p��jemce
- `message` - text zpr�vy
 
Navrac� t��du ***MessageResult***, kter� obsahuje informace o stavu zpr�vy.

- `Id` - ID zpr�vy
- `Status` - status zpr�vy (odesl�no, p�ijato, odesl�ni selhalo, atd.)
- `SentTime` - �as odesl�n�
- `MsgText` - obsah zpr�vy
- `ErrorMsg` - chybov� zpr�va
- `Price` - cena SMS

### TwilioSmsSender

***TwilioSmsSender*** je implementace rozhr�ni ***IMessageSender*** pro br�nu Twilio.

### VonageSmsSender

***VonageSmsSender*** je implementace rozhr�ni ***IMessageSender*** pro br�nu Vonage.

## Pou�it�

### Import bal��ku

St�hn�te si bal��ek SMSLib pomoc� spr�vce bal��k� NuGet nebo jinou, V�mi preferovanou metodou.

`using SMSLib`

### Pou�it� br�ny Twilio

    string accountSid = YOUR_ACCOUNT_SID;
    string authToken = YOUR_AUTH_TOKEN;
    string sender = SENDER_NUMBER;
    string recipient = RECIPIENT_NUMBER;
    string message = YOUR_MESSAGE;

    TwilioSmsSender twilioSmsSender = new TwilioSmsSender();
    MessageResult result = twilioSmsSender.SendMessage(accountSid, authToken, sender, recipient, message);


### Pou�it� br�ny Vonage

    string apiKey = YOUR_API_KEY;
    string apiSecret = YOUR_API_SECRET;
    string sender = SENDER_NUMBER;
    string recipient = RECIPIENT_NUMBER;
    string message = YOUR_MESSAGE;

    VonageSmsSender vonageSmsSender = new VonageSmsSender();
    MessageResult result = vonageSmsSender.SendMessage(apiKey, apiSecret, sender, recipient, message);
