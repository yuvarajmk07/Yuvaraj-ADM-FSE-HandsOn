using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class PackageMaker
    {
        public SweetShopBuilder objBuilder;
       

        public void CreatePackage(SweetShopBuilder objBuilder)
        {
            this.objBuilder = objBuilder;
            objBuilder.SetNoOfSweets();
            objBuilder.SetNoOfSavories();
            
        }
    }
}
