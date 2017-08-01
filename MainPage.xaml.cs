using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Login_form
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            this.DoLogin(userId.Text, password.Text);
        }

        private void SetValue(string Id)
        {
            userId.Text = Id;
        }
        
        private void SetValuePassword(string inputpw)
        {
            password.Text = inputpw;
        }

        private void DoLogin (string Id, string password)
        {
            if (Id == "rambo" && password == "123123")
            {
                this.SetValue("Laboum");
                this.SetValuePassword("loves");
                Login_check.Text = "로그인완료";
            }
            else
            {
                Login_check.Text = "아이디 비밀번호 틀리다 쨔샤";
            }
        }
    }
}
