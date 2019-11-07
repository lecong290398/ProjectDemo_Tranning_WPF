using Demo_Tranning_WPF.Contexts;
using Demo_Tranning_WPF.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Tranning_WPF.ViewModels
{
    public class LoginWindowViewModel : BindableBase
    {
        private string _title = "LOGIN AT SOLUTION";

        private static QuanLyTTContext _context;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public LoginWindowViewModel(QuanLyTTContext context)
        {
            _context = context;
            getInventoryItem();
        }
        static LoginWindowViewModel()
        {
            
        }

        #region InventoryItemBp
        private InventoryItem _InventoryItemBp = null;
        public InventoryItem InventoryItemBp
        {
            get { return _InventoryItemBp; }
            set { SetProperty(ref _InventoryItemBp, value); }
        }
        #endregion


        public void getInventoryItem()
        {
            var InventoryItem = _context.InventoryItem.FirstOrDefault(c => c.Id == "c1ce575b-97b9-40d9-ac26-4d62a5780299");
            InventoryItemBp = InventoryItem;
        }
    }
}
