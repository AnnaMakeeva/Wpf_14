using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;


        public MainWindow()
        {
            InitializeComponent();

            products = new ObservableCollection<Product>();

            products.Add(new Product()
            {
                NameProduct = "Шоколад",
                Price = 250,
                ProductImage = "Data/Shoc.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Яблоки",
                Price = 70,
                ProductImage = "Data/app.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Черешня",
                Price = 150,
                ProductImage = "Data/cher.jpg",
                ProductType = ProductTypes.Food
            });
            products.Add(new Product()
            {
                NameProduct = "Миксер",
                Price = 1320,
                ProductImage = "Data/Mix.jpg",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                NameProduct = "Пылесос",
                Price = 8320,
                ProductImage = "Data/Vaccle.jpg",
                ProductType = ProductTypes.Appliances
            });
            products.Add(new Product()
            {
                NameProduct = "Телевизор",
                Price = 23000,
                ProductImage = "Data/Tel.jpg",
                ProductType = ProductTypes.Appliances
            });
            lstBox.ItemsSource = products;
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    products.Add(new Product()
        //    {
        //        NameProduct = "Продукт 4",
        //        Price = 1300,
        //        ProductImage = "Картинка",
        //        ProductType = ProductTypes.Food
        //    });

        //}
    }
}
