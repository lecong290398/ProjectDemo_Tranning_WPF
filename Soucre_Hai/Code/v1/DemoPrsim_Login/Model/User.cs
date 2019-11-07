using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPrsim_Login.Model
{
    public class User : BindableBase
    {
        #region Id
        private string _Id = null;
        public string Id
        {
            get { return _Id; }
            set { SetProperty(ref _Id, value); }
        }
        #endregion

        #region HoTen
        private string _HoTen = null;
        public string HoTen
        {
            get { return _HoTen; }
            set { SetProperty(ref _HoTen, value); }
        }
        #endregion


        #region MatKhau
        private string _MatKhau = null;
        public string MatKhau
        {
            get { return _MatKhau; }
            set { SetProperty(ref _MatKhau, value); }
        }
        #endregion
    }
}
