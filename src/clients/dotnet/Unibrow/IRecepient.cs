﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unibrow
{
    public interface IRecepient
    {
        string Name { get; }
        void BeginReceive(Entry entry);
    }
}
