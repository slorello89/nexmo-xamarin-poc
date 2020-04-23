using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Nexmo.Client;
namespace NexmoXamarinTest.Droid
{
    public class CallListener : Java.Lang.Object, INexmoIncomingCallListener
    {
        public void OnIncomingCall(NexmoCall p0)
        {
            p0.Answer(new CallDelegate());
        }
    }
}