using System;
using Foundation;
using NexmoXamarinIOS;
namespace NexmoXamarinTest.iOS
{
    public class CallHandler : NXMClientDelegate, ICallHandler
    {
        private NXMCall _call;
        public enum CallStatus
        {
            CallInitiated,
            CallStatusCompleted,
            CallStatusError,
            CallStatusRejected
        }

        public CallStatus HandlerCallStatus { get; set; }
        
        public  CallHandler()
        {
            HandlerCallStatus = CallStatus.CallStatusCompleted;
        }

        public void Login(string jwt)
        {
            //if(NXMClient.Shared == null)
            //    NXMClient.Shared = new NXMClient();
            NXMLogger.SetLogLevel(NXMLoggerLevel.Verbose);
            var client = NXMClient.Shared;
            client.SetDelegate(this);
            client.LoginWithAuthToken(jwt);
        }

        public void StartCall()
        {
            HandlerCallStatus = CallStatus.CallInitiated;
            var client = NXMClient.Shared;
            client.Call("12018747427", NXMCallHandler.Server, new Action<NSError, NXMCall>(((error, call) =>
            {
                if (error != null && error.Code != 0)
                {
                    Console.WriteLine("error encountered " + error.Code);
                }
                else
                {
                    _call = call;
                    _call.SetDelegate(new CallDelegate(this));
                }
            })));
            
        }

        public void EndCall()
        {
            _call.Hangup();            
        }

        public override void DidChangeConnectionStatus(NXMClient client, NXMConnectionStatus status, NXMConnectionStatusReason reason)
        {
            Console.WriteLine("Connection Status Changed: " + status + " Reason: " + reason);
            //do nothing for now
        }

        public override void DidReceiveError(NXMClient client, NSError error)
        {
            Console.WriteLine("Error received " + error.Code);
            //do nothing for now
        }
    }
}
