﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace NexmoXamarinTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {

        string _loggedInUser;
        HttpClient _httpClient;
        ICallHandler _handler;
        public MainPage(ICallHandler handler)
        {
            InitializeComponent();
            _httpClient = new HttpClient();
            _handler = handler;
        }

        void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var siteBase = "SITE_BASE";
            var name = NameEntry.Text.ToLower();
            _loggedInUser = name.ToLower();
            //var strResult = _httpClient.GetAsync($"{siteBase}/token?name={name}").Result.Content.ReadAsStringAsync().Result;
            //var token = JsonConvert.DeserializeObject<TokenRet>(strResult).Token;
            var token = _httpClient.GetAsync($"{siteBase}/token?name={name}").Result.Content.ReadAsStringAsync().Result;
            _handler.Login(token);
        }

        void OnCallButtonClicked(object sender, EventArgs e)
        {
            var callee = _loggedInUser == "steve" ? "joe" : "steve";
            _handler.StartCall(callee);
        }

        void OnCallPstnButtonClicked(object sender, EventArgs e)
        {
            var callee = _loggedInUser == "steve" ? "joe" : "steve";
            _handler.StartCallPstn();
        }

        public class TokenRet
        {
            [JsonProperty("token")]
            public string Token { get; set; }
        }

        private void OnHangupButtonClicked(object sender, EventArgs e)
        {
            _handler.EndCall();
        }
    }
}
