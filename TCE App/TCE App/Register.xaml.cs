using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCE_App.Tables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace TCE_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "user-database.db");
            var db = new SQLiteConnection(path);
            db.CreateTable<RegisteredUsersTable>();

            var item = new RegisteredUsersTable()
            {
                UserEmail = registerEmail.Text,
                UserPassword = registerPassword.Text
            };
            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Success", "Complete Registration?", "Ok", "Cancel");

            });
        }
    }
}