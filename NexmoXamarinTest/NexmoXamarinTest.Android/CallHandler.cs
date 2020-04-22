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
            var factory = Retrofit2.Converter.Gson.GsonConverterFactory.Create();
            //var client = NexmoClientHolder.Client;            
            NexmoClient.Get().Login(jwt);
            
            //client.Login(jwt);
        }

        public void StartCall()
        {          
            
            //var client = NexmoClientHolder.Client;            
            NexmoClient.Get().Call("Steve's Cell", NexmoCallHandler.Server, new CallDelegate());
        }
    }
}
