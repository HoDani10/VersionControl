﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8.Abstractions
{
    public interface CarFactory
    {
        Toy CreateNew();
    }
}