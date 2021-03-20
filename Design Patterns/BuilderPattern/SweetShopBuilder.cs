using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class SweetShopBuilder
    {
        public abstract int SetNoOfSweets();
        public abstract int SetNoOfSavories();
        public abstract ItemCount GetResult();
    }
}
