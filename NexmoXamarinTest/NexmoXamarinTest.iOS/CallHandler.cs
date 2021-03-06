﻿using System;
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

        public void StartCall(string name)
        {
            HandlerCallStatus = CallStatus.CallInitiated;
            var client = NXMClient.Shared;
            client.Call(name, NXMCallHandler.InApp, new Action<NSError, NXMCall>(((error, call) =>
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
            if(_call != null)
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

        public override void DidReceiveCall(NXMClient client, NXMCall call)
        {
            call.Answer(OnComplete);
        }

        public void OnComplete(NSError error)
        {
            Console.WriteLine(error);
        }

        public void StartCallPstn()
        {
            HandlerCallStatus = CallStatus.CallInitiated;
            var client = NXMClient.Shared;
            client.Call("A Number", NXMCallHandler.Server, new Action<NSError, NXMCall>(((error, call) =>
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
    }
}
