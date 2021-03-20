using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class AdultPackage:SweetShopBuilder
    {
       ItemCount count=new ItemCount();

        public override int SetNoOfSweets()
        {
            count.SweetCount = 2;
            return count.SweetCount;

        }

        public override int  SetNoOfSavories()
        {
             count.SavoryCount = 2;
            return count.SavoryCount;
        }
        public override ItemCount GetResult()
        {
            count.Add("Adult Package Sweet Count is:" + SetNoOfSweets());
            count.Add("Adult Package Savory Count is:" + SetNoOfSavories());
            return count;
        }
    }
}
