﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO_Group12405_Console_Lab9.Lab9_1
{
    interface IPubs
    {
        void Subs();
        bool IfSubs { get; set; }
    }
}
