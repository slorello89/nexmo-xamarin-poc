using System;
namespace NexmoXamarinTest
{
    public interface ICallHandler
    {
        void Login(string jwt);
        void StartCall(string name);
    }
}
