﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITest
{
    class ComparerByPrice : IComparer<IWhiteGoods>
    {
        public int Value { get; set; }
        public int Compare(IWhiteGoods x,IWhiteGoods y)
        {
            return x == null ? 1 : x.Price.CompareTo(y.Price);
            /*if (x != null && y != null)
            {
                if (x.Price > y.Price)
                    return 1;
                if (x.Price < y.Price)
                    return -1;
                else return 0;
            }
            else return -1;
    }*/
        }
    }
}
