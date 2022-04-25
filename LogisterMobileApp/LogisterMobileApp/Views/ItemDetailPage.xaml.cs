using LogisterMobileApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace LogisterMobileApp.Views
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