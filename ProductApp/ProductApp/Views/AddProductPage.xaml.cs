using ProductApp.Models;
using ProductApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProductApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddProductPage : ContentPage
    {
        public ProductInfo ProductInfo { get; set; }
        public AddProductPage()
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
        }
         public AddProductPage(ProductInfo prod)
        {
            InitializeComponent();
            BindingContext = new AddProductViewModel();
            if(prod != null)
            {
                BindingContext = ((AddProductViewModel)BindingContext);
            }
        } 
    }
}