﻿using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TodoListClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // Initialize the AuthenticationContext for the application.
            // If the app already has a cached token, the associated authority is used in lieu of the common endpoint;
            // this will make it possible for ADAL to leverage the token cache when requesting tokens for a specific tenant.
            //App.AuthenticationContext = new AuthenticationContext(App.CommonAuthority);
            //if (App.AuthenticationContext.TokenCacheStore.Count > 0)
            //{
            //    string cachedAuthority = App.AuthenticationContext.TokenCacheStore.First().Key.Authority;
            //    App.AuthenticationContext = new AuthenticationContext(cachedAuthority);
            //}
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // if (ApplicationData.Current.LocalSettings.Values["Tenant"] != null)
           //if (App.AuthenticationContext.TokenCacheStore.Count>0)
           // {
           //     this.Frame.Navigate(typeof(TodoListPage));
           // }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SignUpPage));
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(TodoListPage));
        }
    }
}