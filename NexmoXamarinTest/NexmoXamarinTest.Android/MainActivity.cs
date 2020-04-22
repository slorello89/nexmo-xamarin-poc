using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Com.Nexmo.Client;
using Android.Support.V4.App;
using Android;
using Android.Support.Design.Widget;

namespace NexmoXamarinTest.Droid
{
    [Activity(Label = "NexmoXamarinTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var context = Android.App.Application.Context;            
            NexmoClient.Builder builder = new NexmoClient.Builder();
            var client = builder.LogLevel(Com.Nexmo.Utils.Logger.LoggerELogLevel.Verbose).Build(context);
            NexmoClient.Get().SetConnectionListener(new ConnectionListener());
            NexmoClientHolder.Client = client;

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            string[] requiredPermissions = new string[]
            {
                Manifest.Permission.RecordAudio,
                Manifest.Permission.Internet,
                Manifest.Permission.AccessWifiState,
                Manifest.Permission.ChangeWifiState,
                Manifest.Permission.AccessNetworkState,
                Manifest.Permission.ModifyAudioSettings
            };

            ActivityCompat.RequestPermissions(this, requiredPermissions, 123);
            

            LoadApplication(new App(new CallHandler()));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}