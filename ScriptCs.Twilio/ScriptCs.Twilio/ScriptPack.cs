using ScriptCs.Contracts;

namespace ScriptCs.Twilio
{
    public class BoilerplateScriptPack : IScriptPack
    {
        IScriptPackContext IScriptPack.GetContext()
        {
            return new TwilioContext();
        }

        void IScriptPack.Initialize(IScriptPackSession session)
        {
            session.ImportNamespace("Twilio");
        }

        void IScriptPack.Terminate() { }
    }
}
