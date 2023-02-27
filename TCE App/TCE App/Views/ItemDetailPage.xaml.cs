using System.ComponentModel;
using Xamarin.Forms;
using TCE_App.ViewModels;

namespace TCE_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}