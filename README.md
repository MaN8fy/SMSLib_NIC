# SMSLib Dokumentace

## interface - IMessageSender

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

## TwilioSmsSender

***TwilioSmsSender*** je implementace rozhr�ni ***IMessageSender*** pro br�nu Twilio.

Pro odesl�ni zpr�vy sta�� vyvolat funkci SendMessage a p�edat v�ech 5 pot�ebn�ch parametr�.

## VonageSmsSender

***VonageSmsSender*** je implementace rozhr�ni ***IMessageSender*** pro br�nu Vonage.

Pro odesl�ni zpr�vy sta�� vyvolat funkci SendMessage a p�edat v�ech 5 pot�ebn�ch parametr�.
