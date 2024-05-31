using BusinessObject;
using DataAccess;
using DataAccess.DAO;
using DataAccess.Repository.CRepository;
using DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for WindowOrders.xaml
    /// </summary>
    public partial class WindowOrders : Page
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMemberRepository _memberRepository;
        public WindowOrders(IOrderRepository orderRepository, IMemberRepository memberRepository)
        {
            InitializeComponent();
            _orderRepository = orderRepository;
            _memberRepository = memberRepository;
        }

        public void LoadOrderList()
        {
            lvOrders.ItemsSource = _orderRepository.GetAll();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadOrderList();
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
                var memberOrder = _memberRepository.GetById(txtMemberId.Text);
                if (memberOrder == null)
                {
                    MessageBox.Show("Not found this member");
                    return;
                }

                Order? order = new Order
                {
                    MemberId = memberOrder.MemberId,
                    OrderDate = DateTime.Now,
                    RequiredDate = DateTime.Now.AddDays(7),
                    ShippedDate = DateTime.Now.AddDays(3),
                    Freight = 30
                };
                _orderRepository.Create(order);
                LoadOrderList();
                MessageBox.Show($"{order.OrderId} inserted successfully", "Insert Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert Order");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order? order = _orderRepository.GetById(txtOrderId.Text);
                if (order != null)
                {
                    order.OrderDate = DateTime.Parse(txtOrderDate.Text);
                    order.RequiredDate = DateTime.Parse(txtRequiredDate.Text);
                    order.ShippedDate = DateTime.Parse(txtShippedDate.Text);
                    order.Freight = decimal.Parse(txtFreight.Text);

                    _orderRepository.Update(order);
                    LoadOrderList();
                    MessageBox.Show($"{order.OrderId} updated successfully", "Update order");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update order");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Order? order = _orderRepository.GetById(txtOrderId.Text);
                if (order != null)
                {
                    _orderRepository.Delete(order);
                    LoadOrderList();
                    MessageBox.Show($"{order.OrderId} deleted successfully", "Delete Order");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete product");
            }
        }
    }
}
