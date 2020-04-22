using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NexmoXamarinTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        ICallHandler _handler;
        const string JWT = @"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpYXQiOjE1ODc0OTY1NjMsImp0aSI6IjhiMzE5NzAwLTg0MDQtMTFlYS05MDBkLTU3YWZmZDg2ODQ2NCIsInN1YiI6InN0ZXZlIiwiZXhwIjoxNTg3NTgyOTYzLCJhY2wiOnsicGF0aHMiOnsiLyovdXNlcnMvKioiOnt9LCIvKi9jb252ZXJzYXRpb25zLyoqIjp7fSwiLyovc2Vzc2lvbnMvKioiOnt9LCIvKi9kZXZpY2VzLyoqIjp7fSwiLyovaW1hZ2UvKioiOnt9LCIvKi9tZWRpYS8qKiI6e30sIi8qL2FwcGxpY2F0aW9ucy8qKiI6e30sIi8qL3B1c2gvKioiOnt9LCIvKi9rbm9ja2luZy8qKiI6e319fSwiYXBwbGljYXRpb25faWQiOiJiOTQwZGY0Yi04NmVjLTQzOTEtYmI3NC0yNzU3MGY4NDhjMzAifQ.bDlX6mE5mERwRH4C1vQvgT7mTTwQ4j1B3VpVSkb6O1U6f1hzOK06XmbmprmlEhCRJN5v-hjFPRn89xpgQmAzBVjKthkpUAeM2ITF7dyXIKKZTjIHzenY3FM5ObPWF_MDwqElblV8nCuzxNs4zSbCwqSKvD5o8llpSwwLw8qo0XSb3Eiq2_dFLzWqRWOMc4l_lqyb8NJYi_WwSmdNiqqU5WKkPtUfszXpvkOkZsINPifm8IECnBIaKBbSaUBpq8mWP85ySXDn5pWIuXQvEvddxkseQOxIEHtX3lnBEQfDahMG9YyNGYPz8s6uvANitSnDJknXD25FXLP2Dw43UAIA9Q";
        public MainPage(ICallHandler handler)
        {
            InitializeComponent();
            _handler = handler;
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            _handler.Login(JWT);
        }

        void OnCallButtonClicked(object sender, EventArgs e)
        {
            _handler.StartCall();
        }
                    
        

    }
}
