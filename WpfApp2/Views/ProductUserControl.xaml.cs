using System;
using System.Collections.Generic;
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
using WpfApp2.Entities;
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Logique d'interaction pour ProductUserControl.xaml
    /// </summary>
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();

            productDataGrid.ItemsSource = ProductModel.getAll();
        }

        private void saveButton_click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(productReferenceTextBox.Text) && !String.IsNullOrEmpty(productNameTextBox.Text) && 
                !String.IsNullOrEmpty(productPriceTextBox.Text) && !String.IsNullOrEmpty(productAmountTextBox.Text))
            {
                ProductModel.add(new Product(productReferenceTextBox.Text, productNameTextBox.Text, int.Parse(productAmountTextBox.Text), int.Parse(productPriceTextBox.Text)));

                productDataGrid.ItemsSource = ProductModel.getAll();
            }
            else
            {
                if (String.IsNullOrEmpty(productReferenceTextBox.Text))
                    Console.WriteLine("Vide");

                Console.WriteLine("Vide");
            }
        }

        private void productDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(productDataGrid.SelectedItem != null)
            {
                Product p = productDataGrid.SelectedItem as Product;

                productReferenceTextBox.Text = p.reference;
                productNameTextBox.Text = p.name;
                productPriceTextBox.Text = p.price.ToString();
                productAmountTextBox.Text = p.amount.ToString();
            }
        }
    }
}
