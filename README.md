# SMSLib Dokumentace

## interface - IMessageSender

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

## TwilioSmsSender

***TwilioSmsSender*** je implementace rozhráni ***IMessageSender*** pro bránu Twilio.

Pro odesláni zprávy staèí vyvolat funkci SendMessage a pøedat všech 5 potøebných parametrù.

## VonageSmsSender

***VonageSmsSender*** je implementace rozhráni ***IMessageSender*** pro bránu Vonage.

Pro odesláni zprávy staèí vyvolat funkci SendMessage a pøedat všech 5 potøebných parametrù.
