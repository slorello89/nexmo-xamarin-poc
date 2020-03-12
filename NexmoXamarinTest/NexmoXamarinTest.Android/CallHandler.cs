using System;
using Com.Nexmo.Client;
using Com.Nexmo.Clientcore;
namespace NexmoXamarinTest.Droid
{
    public class CallHandler : ICallHandler
    {
        public CallHandler()
        {
        }

        public void Login(string jwt)
        {

            var client = NexmoClientHolder.Client;
            client.Login(jwt);
        }

        public void StartCall()
        {
            var client = NexmoClientHolder.Client;
            client.Call("12018675309", NexmoCallHandler.Server, new CallDelegate());
        }
    }
}
