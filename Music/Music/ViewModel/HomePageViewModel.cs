using Music.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Music.ViewModel
{
    public class HomePageViewModel:NotifyModel
    {
        public INavigation Navigation { get; set; }
        public HomePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            PopulateProduct();
        }

        private void PopulateProduct()
        {
          var resp=  new List<Product>()
            {
                new Product(){ Id=1, Name="Product 1", Description="Product 1 Description"},
                new Product(){ Id=2, Name="Product 2", Description="Product 2 Description"},
                new Product(){ Id=3, Name="Product 3", Description="Product 3 Description"},
                new Product(){ Id=4, Name="Product 4", Description="Product 4 Description"},
                new Product(){ Id=5, Name="Product 5", Description="Product 5 Description"},
                new Product(){ Id=6, Name="Product 6", Description="Product 6 Description"},
                new Product(){ Id=7, Name="Product 7", Description="Product 7 Description"}
            };
            Products = new ObservableCollection<Product>(resp as List<Product>);
        }

        Product _selectedProduct;
        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (value != null)
                {
                   // Navigation.PushAsync(new ProductDetailsPage(value));
                    _selectedProduct = value;
                    OnPropertyChanged();
                }
            }
        }






        ObservableCollection<Product> _products;
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged();
            }
        }
    }
}

