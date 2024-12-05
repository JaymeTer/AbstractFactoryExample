﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryExample
{
    //Abstract Factory
    internal interface IFactory
    {
        ILanguage CreateLanguage();
        INation CreateNation();
    }
}
