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
using Com.Nexmo.Client.Request_listener;

namespace NexmoXamarinTest.Droid
{
    public class ConnectionListener : Java.Lang.Object, INexmoConnectionListener
    {       

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void OnConnectionStatusChange(NexmoConnectionListenerConnectionStatus p0, NexmoConnectionListenerConnectionStatusReason p1)
        {
            Console.WriteLine(p0.ToString() + " " + p1.ToString());
        }
    }
}