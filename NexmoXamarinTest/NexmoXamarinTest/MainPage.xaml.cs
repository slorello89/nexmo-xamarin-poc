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
        const string JWT = @"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJpYXQiOjE1ODM5NTkyNTksImp0aSI6IjlkNmQ2NzYwLTYzZDgtMTFlYS04YWViLTQ5YjA2MmFmZGM5NyIsInN1YiI6ImphbmUiLCJleHAiOjE1ODQwNDU2NTksImFjbCI6eyJwYXRocyI6eyIvKi91c2Vycy8qKiI6e30sIi8qL2NvbnZlcnNhdGlvbnMvKioiOnt9LCIvKi9zZXNzaW9ucy8qKiI6e30sIi8qL2RldmljZXMvKioiOnt9LCIvKi9pbWFnZS8qKiI6e30sIi8qL21lZGlhLyoqIjp7fSwiLyovYXBwbGljYXRpb25zLyoqIjp7fSwiLyovcHVzaC8qKiI6e30sIi8qL2tub2NraW5nLyoqIjp7fX19LCJhcHBsaWNhdGlvbl9pZCI6ImJkZmE0OWQzLWU0YzMtNDRhMS04MjgxLWI0MTBiY2Y3OWVlYiJ9.YDzrebEGvGZZly78a6gaxH5vx4aYINmKVO_N2QlrT8ZcnqQHfKHECWf9JyqUeX7EIjfJZaQIhhlWviU920XVVAwc9Xuy6XuRQhxOMNAvOfVdDvxdmiSoottw7LpFHYZZ4Zf3UZ4Dt_O6fI1Xkj3MpT6GyS7B1lIdPLNMd79vfjJwrswKFibIG_Rkd6HKXTlEaCt7u2a3WifJ-4wVLN8SUPhtpcnUoGMJQc1ilhEtbLoE7Tvf0HJWf1NM1GE8K-Hqw48zXHe0ThjpcdlOy36mnxycFIfByBxgydiSe0jPN7Z3OQu64bPUNHSLt5Ebb78LE54yAeoGLy3SyqMcXvCQMQ";
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
