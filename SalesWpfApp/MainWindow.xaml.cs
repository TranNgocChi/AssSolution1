using BusinessObject;
using DataAccess.Repository.IRepository;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SalesWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMemberRepository _memberRepository;
        private readonly WindowLogin _windowLogin;
        public MainWindow(IMemberRepository memberRepository, WindowLogin windowLogin)
        {
            InitializeComponent();
            _memberRepository = memberRepository;   
            _windowLogin = windowLogin;
        }

        private void NavigateToLogin()
        {
            MainFrame.Navigate(_windowLogin);
        }
        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtCompanyName.Text)
                    || String.IsNullOrEmpty(txtCountry.Text) || String.IsNullOrEmpty(txtEmail.Text)
                    || String.IsNullOrEmpty(txtPassword.Password))
                {
                    MessageBox.Show("You have to input all of your information");
                }
                else
                {
                    Member member = new Member
                    {
                        Email = txtEmail.Text,
                        CompanyName = txtCompanyName.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Password
                    };
                    _memberRepository.Create(member);
                    MessageBox.Show("Register Successfully!");
                    NavigateToLogin();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Register Member");
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(_windowLogin);
        }
    }
}