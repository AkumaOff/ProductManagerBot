﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagerBot.Services.AdminCheckService
{
    internal interface IAdminCheckService
    {
        bool Check(long userid);
    }
}
