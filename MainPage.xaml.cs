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

        private void DoLogin(string Id, string password)
        {
            string dbPassword = "123123";
            string salt = "$2a$13$/laboumskeyvaluessou";
            string userHashPassword = hashPassword(dbPassword, salt);
            string inputPassword = hashPassword(password, salt);

            if (Id == "rambo" && userHashPassword == GetInputPassword(inputPassword))
            {
                this.SetValue("rambo");
                this.SetValuePassword("123123");
                Login_check.Text = "로그인완료";
            }
            else
            {
                Login_check.Text = "아이디 혹은 비밀번호가 틀린 것 같습니다가 아니라 틀렷습니다. 난 확실하거든";
            }
        }

        private static string GetInputPassword(string inputPassword)
        {
            return inputPassword;
        }

        public static string hashPassword(string password, string salt)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, salt);
        }
    }
}
