using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace WPFNETCORE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            

        }
        Class1 cl1 = new Class1();
       
       


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            CRUD crud = new CRUD();
            Boolean check = cl1.thucthi("INSERT INTO Register (HoTen,TaiKhoan,MatKhau) VALUES (N'" + txtHoTen.Text + "',N'"+txtTK.Text+"',N'"+txtMatKhau.Text+"')");

            if (check == true)
            {
                MessageBox.Show("Thành công ");
               
            }
            else
            {
                MessageBox.Show("Đăng ký không thành công !!!");
            }
        }

        private void txtHoTen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
