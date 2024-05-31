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
    /// Interaction logic for WindowHome.xaml
    /// </summary>
    public partial class WindowHome : Page
    {
        private readonly WindowMembers _windowMembers;
        private readonly WindowOrders _windowOrders;
        private readonly WindowProducts _windowProducts;
        private readonly WindowOrderDetails _windowOrderDetails;
        public WindowHome(WindowMembers windowMembers, WindowOrders windowOrders,
            WindowProducts windowProducts, WindowOrderDetails windowOrderDetails)
        {
            InitializeComponent();
            _windowMembers = windowMembers;
            _windowOrders = windowOrders;
            _windowProducts = windowProducts;
            _windowOrderDetails = windowOrderDetails;
        }

        private void btnManageMember(object sender, RoutedEventArgs e)
        {
            HomeFrame.Navigate(_windowMembers);
        }

        private void btnManageProduct(object sender, RoutedEventArgs e)
        {
            HomeFrame.Navigate(_windowProducts);
        }

        private void btnManageOrder(object sender, RoutedEventArgs e)
        {
            HomeFrame.Navigate(_windowOrders);
        }

        private void btnManageOrderDetail(object sender, RoutedEventArgs e)
        {
            HomeFrame.Navigate(_windowOrderDetails);
        }
    }
}
