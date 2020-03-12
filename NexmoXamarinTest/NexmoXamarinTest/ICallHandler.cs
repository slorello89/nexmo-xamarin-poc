using System;
namespace NexmoXamarinTest
{
    public interface ICallHandler
    {
        void Login(string userId);
        void StartCall();
    }
}
