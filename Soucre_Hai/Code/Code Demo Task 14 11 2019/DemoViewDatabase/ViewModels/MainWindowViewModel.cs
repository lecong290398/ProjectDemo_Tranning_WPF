using DemoViewDatabase.Contexts;
using DemoViewDatabase.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace DemoViewDatabase.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Products Application";

        private static ATeCommerceContext _Context;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(ATeCommerceContext Context)
        {
            _Context = Context;
            GetALLProducts();
        }


        #region BindProp


        #region ProductBindProp
        private Products_With_Categories _ProductBindProp = new Products_With_Categories();
        public Products_With_Categories ProductBindProp
        {
            get { return _ProductBindProp; }
            set { SetProperty(ref _ProductBindProp, value); }
        }
        #endregion


        #region ListUserBindProp
        private ObservableCollection<Products_With_Categories> _listProductBindProp;
        public ObservableCollection<Products_With_Categories> listProductBindProp
        {
            get { return _listProductBindProp; }
            set { SetProperty(ref _listProductBindProp, value); }
        }
        #endregion

        //Hiện tất cả user
        public void GetALLProducts()
        {
            var list = _Context.Products_With_Categories.ToList();
            listProductBindProp = new ObservableCollection<Products_With_Categories>(list);
        }

        #endregion



        //Chỉnh sửa user
        public bool EditUser(Products_With_Categories Products)
        {
            try
            {
                _Context.Products_With_Categories.Update(Products);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception error)
            {

                throw error;
            }
        }
    }
}
