# SMSLib_NIC Dokumentace

## IMessageSender

Rozhrani ***IMessageSender*** definuje funkci SendMessage, ktera slouzi k odeslani zpravy.

Tato funkce prijima 5 parametru:

- `accountSid` - ID uctu
- `authToken` - autentifikacni token
- `sender` - cislo odesilatele
- `recipient` - cislo prijemce
- `message` - text zpravy
 
Navraci tridu ***MessageResult***, ktera obsahuje informavce o stavu zpravy.

## TwilioSmsSender

***TwilioSmsSender*** je implementace rozhrani ***IMessageSender*** pro branu Twilio.

Pro odeslani zpravy staci vyvolat funkci SendMessage a predat vsech 5 potrebnych parametru. 
