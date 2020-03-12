using Foundation;
using NexmoXamarinIOS;
namespace NexmoXamarinTest.iOS
{
    public class CallDelegate : NXMCallDelegate
    {
        private CallHandler _handler;
        // public NXMCall Call { get; set; }

        public CallDelegate(CallHandler handler)
        {
            _handler = handler;
            
        }
        public override void DidUpdate(NXMCall call, NXMCallMember callMember, bool muted)
        {
            // throw new System.NotImplementedException();
        }

        public override void DidReceive(NXMCall call, NSError error)
        {
            // throw new System.NotImplementedException();
        }

        public override void DidUpdate(NXMCall call, NXMCallMember callMember, NXMCallMemberStatus status)
        {
            System.Console.WriteLine("Call status changed " + status);
            if (status == NXMCallMemberStatus.Completed || status == NXMCallMemberStatus.Canceled)
            {
                _handler.HandlerCallStatus = CallHandler.CallStatus.CallStatusCompleted;
                call?.Hangup();
                call = null;
            }

            if (callMember.MemberId != call?.MyCallMember.MemberId &&
                (status == NXMCallMemberStatus.Failed || status == NXMCallMemberStatus.Busy))
            {
                _handler.HandlerCallStatus = CallHandler.CallStatus.CallStatusError;
                call?.Hangup();
                call = null;
            }

            if (call?.MyCallMember.MemberId != callMember.MemberId && (status == NXMCallMemberStatus.Rejected))
            {
                _handler.HandlerCallStatus = CallHandler.CallStatus.CallStatusRejected;
                call?.Hangup();
                call = null;
            }
        }
    }
}