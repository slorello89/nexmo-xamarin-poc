using System;
using System.Collections.Generic;
using System.Linq;
using AVFoundation;
using Foundation;
using UIKit;
using NexmoXamarinIOS;

namespace NexmoXamarinTest.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            AVAudioSession.SharedInstance().RequestRecordPermission(
                new AVPermissionGranted((bool granted) =>
                {
                    Console.WriteLine("Record permission grainting is: " + granted);
                }));

            //var logFileName = NXMLogger.LogFileNames;
            //Console.WriteLine(logFileName[0])
            
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            
        }
    }
}
