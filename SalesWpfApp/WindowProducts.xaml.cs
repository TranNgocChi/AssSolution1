using BusinessObject;
using DataAccess.Repository.CRepository;
using DataAccess.Repository.IRepository;
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

namespace SalesWpfApp
{
    /// <summary>
    /// Interaction logic for WindowProducts.xaml
    /// </summary>
    public partial class WindowProducts : Page
    {
        private readonly IProductRepository _productRepository;
        public WindowProducts(IProductRepository productRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
        }

        public void LoadProductList()
        {
            lvProducts.ItemsSource = _productRepository.GetAll();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadProductList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product? product = new Product
                {
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryId.Text),
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                };
                _productRepository.Create(product);
                LoadProductList();
                MessageBox.Show($"{product.ProductId} inserted successfully", "Insert Product");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Product");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product? product = _productRepository.GetById(txtProductId.Text);
                if (product != null)
                {
                    product.ProductName = txtProductName.Text;
                    product.CategoryId = int.Parse(txtCategoryId.Text);
                    product.Weight = txtWeight.Text;
                    product.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    product.UnitsInStock = int.Parse(txtUnitsInStock.Text);

                    _productRepository.Update(product);
                    LoadProductList();
                    MessageBox.Show($"{product.ProductId} updated successfully", "Update product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product? product = _productRepository.GetById(txtProductId.Text);
                if (product != null)
                {
                    _productRepository.Delete(product);
                    LoadProductList();
                    MessageBox.Show($"{product.ProductId} deleted successfully", "Delete product");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product");
            }
        }
    }
}
