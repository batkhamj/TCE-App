using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCE_App.Tables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCE_App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "user-database.db");
            var db = new SQLiteConnection(path);
            var query = db.Table<RegisteredUsersTable>().Where(u => u.UserEmail.Equals(emailEntry.Text) && u.UserPassword.Equals(passwordEntry.Text)).FirstOrDefault();
        
            if(query != null)
            {
                Application.Current.MainPage = new NavigationPage(new Home());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Error", "Invalid Email or Password", "Ok", "Cancel");
                    if (result)
                    {
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await Navigation.PushAsync(new Login());
                    }

                });
            }
        }

        async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}