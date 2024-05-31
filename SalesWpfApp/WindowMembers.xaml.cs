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
    /// Interaction logic for WindowMembers.xaml
    /// </summary>
    public partial class WindowMembers : Page
    {
        private readonly IMemberRepository _memberRepository;
        public WindowMembers(IMemberRepository memberRepository)
        {
            InitializeComponent();
            _memberRepository = memberRepository;
        }

        private Member? GetMemberObject()
        {
            Member? member = null;
            try
            {
                member = new Member
                {
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return member;
        }
        public void LoadMemberList()
        {
            lvMembers.ItemsSource = _memberRepository.GetAll();
        }
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LoadMemberList();
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
                Member? member = GetMemberObject();
                _memberRepository.Create(member);
                LoadMemberList();
                MessageBox.Show($"{member.MemberId} inserted successfully", "Insert Member");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert member");
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member? member = _memberRepository.GetById(txtMemberId.Text);
                if (member != null)
                {
                    member.Email = txtEmail.Text;
                    member.CompanyName = txtCompanyName.Text;
                    member.City = txtCity.Text;
                    member.Country = txtCountry.Text;
                    member.Password = txtPassword.Text;

                    _memberRepository.Update(member);
                    LoadMemberList();
                    MessageBox.Show($"{member.MemberId} updated successfully", "Update member");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update member");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Member? member = _memberRepository.GetById(txtMemberId.Text);
                if(member != null)
                {
                    _memberRepository.Delete(member);
                    LoadMemberList();
                    MessageBox.Show($"{member.MemberId} deleted successfully", "Delete member");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete member");
            }
        }
    }
}
