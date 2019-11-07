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

namespace DeMoRegister
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person cc = new Person { Name = "",email =""};
       

        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = cc;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(())
            string message ="ĐK: Thành công" + "\nTên:"+ cc.Name + " Mail: " + cc.email;
            MessageBox.Show(message);

        }
        public class Person
        {

            private string nameValue;

            public string Name
            {
                get { return nameValue; }
                set { nameValue = value; }
            }

            private string emailValue;

            public string email
            {
                get { return emailValue; }

                set
                {
                    emailValue = value;
                }

            }
        }
    }
 }

