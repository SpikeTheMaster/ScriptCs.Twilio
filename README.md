# ScriptCs.Twilio

Use as below (after moving DLLs into bin folder):

```
var twilio = Require<TwilioContext>();

var client = twilio.Client("AccountSID","Auth Token");

var message = client.SendSmsMessage("From", "To", "Message");

if (message.RestException != null) {
        var error = message.RestException.Message;
        Console.WriteLine(error);
}
```