using BusinessObject;
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
    /// Interaction logic for WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Page
    {
        private readonly WindowHome _windowHome;
        private readonly IMemberRepository _memberRepository;
        public WindowLogin(WindowHome windowHome, IMemberRepository memberRepository)
        {
            InitializeComponent();
            _windowHome = windowHome;
            _memberRepository = memberRepository;
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member? foundMember = null;
                var listMember = _memberRepository.GetAll();
                foreach(var member in listMember)
                {
                    if(member.Email == txtEmail.Text && member.Password == txtPassword.Password)
                    {
                        foundMember = member;
                        break;
                    }
                }

                if(foundMember == null)
                {
                    MessageBox.Show("Not found this member! Try again", "Login");
                    return;
                }
                MessageBox.Show("Login Successfully!");
                NavigateToHome();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Emai or Password are not valid");
            }
        }

        private void NavigateToHome()
        {
            LoginFrame.Navigate(_windowHome);
        }
    }
}
