using ScriptCs.Contracts;
using Twilio;

namespace ScriptCs.Twilio
{
    public class TwilioContext : IScriptPackContext
    {
        public TwilioRestClient Client(string sid, string token)
        {
            return new TwilioRestClient(sid, token);
        }
    }
}