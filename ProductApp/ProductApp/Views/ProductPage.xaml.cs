
using Android.Widget;
using ProductApp.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductPage : ContentPage
    {
        ProductViewModel productViewModel;
        public ProductPage()
        {
            InitializeComponent();
            BindingContext = productViewModel = new ProductViewModel(Navigation);
            Console.WriteLine("The Products Inserted"+productViewModel);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            productViewModel.OnAppearing();
        }
    }
}