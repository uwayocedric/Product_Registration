using ProductApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ProductApp.Views
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