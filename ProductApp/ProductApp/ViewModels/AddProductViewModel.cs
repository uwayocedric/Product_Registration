using ProductApp.Models;
using ProductApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProductApp.ViewModels
{
    public class AddProductViewModel:BaseProductViewModel
    {
        public Command SaveCommand { get; set; }
        public Command CancelCommand { get; set; }
        public AddProductViewModel()
        {
            SaveCommand = new Command(OnSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged += (_, __) => SaveCommand.ChangeCanExecute();
            ProductInfo = new ProductInfo();
        }

        private async void OnSave()
        {
            var product = ProductInfo;
            Console.WriteLine("The Product to be Saved " + product.ProductId);
            await App.ProductService.AddProductAsync(product);
            await Shell.Current.GoToAsync("..");
        }

        private async void OnCancel()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
