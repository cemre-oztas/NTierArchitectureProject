﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMagazineService
    {
        List<Magazine> GetAll();
        void Add(Magazine magazine);
    }
}