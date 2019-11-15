using BlankCoreApp2.Models;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows;

namespace BlankCoreApp2.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }

        private Register _dangky = new Register();
        public Register DangKy
        {
            get { return _dangky; }
            set { SetProperty(ref _dangky, value); }
        }
        private DelegateCommand _dangkyCommand;
        public DelegateCommand DangKyCommand =>
            _dangkyCommand ?? (_dangkyCommand = new DelegateCommand(ExecuteDangkyCommand));

        void ExecuteDangkyCommand()

        {
            MessageBox.Show("dk thanh cong: " + DangKy.MatKhau, "Thong bao");
        }


    }
}
