﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace Investing.View
{
    public interface ICompanyView
    {
        ICompany Company { get; set; }
    }
}
