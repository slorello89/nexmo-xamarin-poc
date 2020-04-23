using System;
using Com.Nexmo.Client;
using Com.Nexmo.Clientcore;
namespace NexmoXamarinTest.Droid
{
    public class CallHandler : ICallHandler
    {
        public CallDelegate _Delegate = new CallDelegate();
        public CallHandler()
        {
        }

        public void EndCall()
        {
            _Delegate.HangUp(); 
        }

        public void Login(string jwt)
        {
            var factory = Retrofit2.Converter.Gson.GsonConverterFactory.Create();
            
            //var client = NexmoClientHolder.Client;            
            NexmoClient.Get().Login(jwt);
            NexmoClient.Get().AddIncomingCallListener(new CallListener());
            //client.Login(jwt);
        }

        public void StartCall(string name)
        {   
            NexmoClient.Get().Call(name, NexmoCallHandler.InApp, _Delegate);
        }

        public void StartCallPstn()
        {
            NexmoClient.Get().Call("A number", NexmoCallHandler.Server, _Delegate);
        }
    }
}
