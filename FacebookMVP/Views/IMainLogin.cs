﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookMVP.Views
{
    public interface IMainLogin
    {
         string Username { get; set; }
         string Password { get; set; }
         object DataGridViewAccount { get; set; }
    }
}
