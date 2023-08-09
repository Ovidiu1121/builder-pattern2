using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema86_BuilderPattern2.model
{
    public class Magazine:Shop
    {
        public string city;
        public string name;

        public Magazine(string name,string city)
        {
            this.name = name;
            this.city = city;

            Console.WriteLine("\nThe CEO has decided to build a "+this.name+" Magazine in "+this.city+" City");
        }

    }
}
