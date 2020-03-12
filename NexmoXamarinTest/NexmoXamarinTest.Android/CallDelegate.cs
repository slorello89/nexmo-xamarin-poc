using System;
using Com.Nexmo.Client;
using Com.Nexmo.Client.Request_listener;
using Java.Interop;

namespace NexmoXamarinTest.Droid
{
    public class CallDelegate : Java.Lang.Object, Com.Nexmo.Client.Request_listener.INexmoRequestListener
    {
        public CallDelegate()
        {
        }

        

        //public JniManagedPeerStates JniManagedPeerState => this.JniManagedPeerState;

        

        public void Disposed()
        {
            //throw new NotImplementedException();
        }

        public void DisposeUnlessReferenced()
        {
            //throw new NotImplementedException();
        }

        public void Finalized()
        {
            //throw new NotImplementedException();
        }

        public void OnError(NexmoApiError p0)
        {
            Console.WriteLine("error encounterd " + p0.Message);
        }

        public void OnSuccess(Java.Lang.Object p0)
        {
            
        }

        public void SetJniIdentityHashCode(int value)
        {
            //throw new NotImplementedException();
        }

        public void SetJniManagedPeerState(JniManagedPeerStates value)
        {
            //throw new NotImplementedException();
        }

        public void SetPeerReference(JniObjectReference reference)
        {
            //throw new NotImplementedException();
        }

        public void UnregisterFromRuntime()
        {
            //throw new NotImplementedException();
        }
    }
}
