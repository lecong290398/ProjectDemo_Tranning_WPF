using DemoPrsim_Login.Model;
using DemoPrsim_Login.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Windows;

namespace DemoPrsim_Login.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "LOGIN AT SOLUTION";
        private readonly IRegionManager _regionManager;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }

        #region BindProp

        #region UserBindProp
        private User _UserBindProp = new User();
        public User UserBindProp
        {
            get { return _UserBindProp; }
            set { SetProperty(ref _UserBindProp, value); }
        }
        #endregion

        #region CheckComfimBindProp
        private bool _CheckComfimBindProp = false;
        public bool CheckComfimBindProp
        {
            get { return _CheckComfimBindProp; }
            set
            {
                SetProperty(ref _CheckComfimBindProp, value);
                if (value == true)
                {
                    IsVisibleBindProp = true;
                }
                if (value == false)
                {
                    IsVisibleBindProp = false;
                }
            }
        }
        #endregion

        #region ComfimPasswordBindProp
        private string _ComfimPasswordBindProp = null;
        public string ComfimPasswordBindProp
        {
            get { return _ComfimPasswordBindProp; }
            set { SetProperty(ref _ComfimPasswordBindProp, value); }
        }
        #endregion

        #region IsVisibleBindProp
        private bool _IsVisibleBindProp = false;
        public bool IsVisibleBindProp
        {
            get { return _IsVisibleBindProp; }
            set { SetProperty(ref _IsVisibleBindProp, value); }
        }
        #endregion


        #endregion



        #region Command
        private DelegateCommand _DangKy;
        public DelegateCommand DangKyCommand =>
            _DangKy ?? (_DangKy = new DelegateCommand(ExecuteDangKyCommand));

        void ExecuteDangKyCommand()
        {
            if (UserBindProp != null)
            {
                if (ComfimPasswordBindProp == UserBindProp.Password)
                {
                    UserBindProp.Id = Guid.NewGuid().ToString();
                    MessageBox.Show("Đăng ký thành công với user" + UserBindProp.UserName, "Thông báo");

                    LoginWindow login = new LoginWindow();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("2 Password không giống nhau", "Thông báo");
                }
            }
        }

        private DelegateCommand _Exit;
        public DelegateCommand ExitCommand =>
            _Exit ?? (_Exit = new DelegateCommand(ExecuteExitCommand));

        void ExecuteExitCommand()
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion

    }
}
