using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PackageMaker pm = new PackageMaker();
            SweetShopBuilder childPackage = new ChildPackage();
            SweetShopBuilder adultPackage = new AdultPackage();
            pm.CreatePackage(childPackage);
            childPackage.GetResult().Display();
            pm.CreatePackage(adultPackage);
            adultPackage.GetResult().Display();
            Console.Read();

        }
    }
}
