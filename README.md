# SMSLib_NIC Dokumentace

## IMessageSender

Rozhran� ***IMessageSender*** definuje funkci SendMessage, kter� slou�� k odesl�n� zpr�vy.

Tato funkce p��j�m� 5 parametr�:

- `accountSid` - ID ��tu
- `authToken` - autentifika�n� token
- `sender` - ��slo odes�latele
- `recipient` - ��slo p��jemce
- `message` - text zpr�vy
 
## TwilioSmsSender

***TwilioSmsSender*** je implementace rozhran� ***IMessageSender*** pro br�nu Twilio.

Pro odesl�n� zpr�vy sta�� vyvolat funkci SendMessage a p�edat v�ech 5 pot�ebn�ch parametr�. 
