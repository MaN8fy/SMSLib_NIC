# SMSLib_NIC Dokumentace

## IMessageSender

Rozhraní ***IMessageSender*** definuje funkci SendMessage, která slouí k odeslání zprávy.

Tato funkce pøíjímá 5 parametrù:

- `accountSid` - ID úètu
- `authToken` - autentifikaèní token
- `sender` - èíslo odesílatele
- `recipient` - èíslo pøíjemce
- `message` - text zprávy
 
## TwilioSmsSender

***TwilioSmsSender*** je implementace rozhraní ***IMessageSender*** pro bránu Twilio.

Pro odeslání zprávy staèí vyvolat funkci SendMessage a pøedat všech 5 potøebnıch parametrù. 
