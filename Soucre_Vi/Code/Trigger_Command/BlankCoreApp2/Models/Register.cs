using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlankCoreApp2.Models
{
    public partial class Register
    {
        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }
        [StringLength(10)]
        public string TaiKhoan { get; set; }
        [Required]
        [StringLength(10)]
        public string MatKhau { get; set; }
    }
}
