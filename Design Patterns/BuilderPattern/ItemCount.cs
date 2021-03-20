using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class ItemCount
    {
        private List<string> ItemList = new List<string>();
        public int SweetCount { get; set; }
        public int SavoryCount { get; set; }
        public void Add(string package)
        {
            ItemList.Add(package);
        }

        public void Display()
        {
            foreach(var i in ItemList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
