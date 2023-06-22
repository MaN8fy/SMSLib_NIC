# SMSLib Dokumentace

## Požadavky

.NET 5.0 or above, .NET Standard 2.0 or above.

## Struktura

### interface - IMessageSender

Rozhraní ***IMessageSender*** definuje funkci SendMessage, která slouží k odeslání zprávy.

Tato funkce pøijímá 5 parametrù:

- `apiKey` - ID úètu
- `apiSecret` - autentifikaèní token
- `sender` - èíslo odesílatele
- `recipient` - èíslo pøíjemce
- `message` - text zprávy
 
Navrací tøídu ***MessageResult***, která obsahuje informace o stavu zprávy.

- `Id` - ID zprávy
- `Status` - status zprávy (odesláno, pøijato, odesláni selhalo, atd.)
- `SentTime` - èas odeslání
- `MsgText` - obsah zprávy
- `ErrorMsg` - chybová zpráva
- `Price` - cena SMS

### TwilioSmsSender

***TwilioSmsSender*** je implementace rozhráni ***IMessageSender*** pro bránu Twilio.

### VonageSmsSender

***VonageSmsSender*** je implementace rozhráni ***IMessageSender*** pro bránu Vonage.

## Použití

### Import balíèku

Stáhnìte si balíèek SMSLib pomocí správce balíèkù NuGet nebo jinou, Vámi preferovanou metodou.

`using SMSLib`

### Použití brány Twilio

    string accountSid = YOUR_ACCOUNT_SID;
    string authToken = YOUR_AUTH_TOKEN;
    string sender = SENDER_NUMBER;
    string recipient = RECIPIENT_NUMBER;
    string message = YOUR_MESSAGE;

    TwilioSmsSender twilioSmsSender = new TwilioSmsSender();
    MessageResult result = twilioSmsSender.SendMessage(accountSid, authToken, sender, recipient, message);


### Použití brány Vonage

    string apiKey = YOUR_API_KEY;
    string apiSecret = YOUR_API_SECRET;
    string sender = SENDER_NUMBER;
    string recipient = RECIPIENT_NUMBER;
    string message = YOUR_MESSAGE;

    VonageSmsSender vonageSmsSender = new VonageSmsSender();
    MessageResult result = vonageSmsSender.SendMessage(apiKey, apiSecret, sender, recipient, message);
