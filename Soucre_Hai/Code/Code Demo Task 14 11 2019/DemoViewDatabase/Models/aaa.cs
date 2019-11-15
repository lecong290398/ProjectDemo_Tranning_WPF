using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoViewDatabase.Models
{
    public partial class aaa
    {
        [StringLength(10)]
        public string aa { get; set; }
    }
}
