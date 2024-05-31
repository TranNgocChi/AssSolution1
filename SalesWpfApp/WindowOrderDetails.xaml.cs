using BusinessObject;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
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
    /// Interaction logic for WindowOrderDetails.xaml
    /// </summary>
    public partial class WindowOrderDetails : Page
    {
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMemberRepository _memberRepository;
        private readonly IProductRepository _productRepository;
        public WindowOrderDetails(IProductRepository productRepository, IMemberRepository memberRepository, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _memberRepository = memberRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        public void LoadOrderDetailList()
        {
            lvOrderDetails.ItemsSource = _orderRepository.GetAll();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadOrderDetailList();
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
                var order = _orderRepository.GetById(txtOrderId.Text);
                if (order == null)
                {
                    MessageBox.Show("Not found this order");
                    return;
                }

                var product = _productRepository.GetById(txtProductId.Text);
                if (product == null)
                {
                    MessageBox.Show("Not found this product");
                    return;
                }

                OrderDetail? orderDetail = new OrderDetail
                {
                    OrderId = Guid.Parse(txtOrderId.Text),
                    ProductId = Guid.Parse(txtProductId.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Discount  = float.Parse(txtDiscount.Text)
                };
                _orderDetailRepository.Create(orderDetail);
                LoadOrderDetailList();
                MessageBox.Show($"{order.OrderId} inserted successfully", "Insert Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Order");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var order = _orderRepository.GetById(txtOrderId.Text);
            if (order == null)
            {
                MessageBox.Show("Not found this order");
                return;
            }

            var product = _productRepository.GetById(txtProductId.Text);
            if (product == null)
            {
                MessageBox.Show("Not found this product");
                return;
            }

            OrderDetail? orderDetail = _orderDetailRepository.GetById(txtOrderDetailId.Text);
            if (orderDetail != null)
            {
                _orderDetailRepository.Delete(orderDetail);
                LoadOrderDetailList();
                MessageBox.Show($"{orderDetail.OrderDetailId} deleted successfully", "Delete OrderDetail");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderDetail? orderDetail = _orderDetailRepository.GetById(txtOrderDetailId.Text);
                if (orderDetail != null)
                {
                    orderDetail.OrderId = Guid.Parse(txtOrderId.Text);
                    orderDetail.ProductId = Guid.Parse(txtProductId.Text);
                    orderDetail.UnitPrice = decimal.Parse(txtUnitPrice.Text);
                    orderDetail.Quantity = int.Parse(txtQuantity.Text);
                    orderDetail.Discount = float.Parse(txtDiscount.Text);
                    LoadOrderDetailList();
                    MessageBox.Show($"{orderDetail.OrderDetailId} deleted successfully", "Delete OrderDetail");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete OrderDetail");
            }
        }
    }
}
