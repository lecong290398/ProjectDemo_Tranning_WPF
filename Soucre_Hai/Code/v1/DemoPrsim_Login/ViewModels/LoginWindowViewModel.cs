using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrsim_Login.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        private string _title = "LOGIN AT SOLUTION";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public LoginWindowViewModel()
        {

        }
    }
}
