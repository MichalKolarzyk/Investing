﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.Repository
{
    public interface IDataBaseManager
    {
        void Create();
        void Clear();
        void Delete();
    }
}
