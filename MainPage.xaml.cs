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
            if (Id == "rambo" && password == "123123")
            {
                var getRandomStirng = this.getRandom(22, "alnum");
                var sprintfString = String.Format("%02d", 10);
                var salt = String.Format("$2y${0}{1}", sprintfString, getRandomStirng);

                this.SetValue("SNSD");
                this.SetValuePassword("loves");
                Login_check.Text = "로그인완료";
            }
            else
            {
                Login_check.Text = "아이디 혹은 비밀번호가 틀린 것 같습니다가 아니라 틀렷습니다. 난 확실하거든";
            }
        }

        public string getRandom(int length, string format = "alnum")
        {
            int entropyRequiredBytes = 0;
            if (format != "alnum")
            {
                int entropyRequired = 0;
            }
            else
            {
                Random Random = new Random();

                int entropyRequired = (int)Math.Ceiling((decimal)length * 3 / 4);
                for (int i = 0; i <= entropyRequiredBytes; i++)
                {
                    var entropy = (int)Random.Next(0, 65536);
                }
            }

            return "merong";
        }
    }
}
