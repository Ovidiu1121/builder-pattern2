using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema86_BuilderPattern2.model
{
    public class Shop
    {

        private LinkedList<string> lista;

        public Shop()
        {
            lista = new LinkedList<string>();
        }

        public void add(string part)
        {
            lista.AddLast(part);
        }

        public void displayShop()
        {

            Console.WriteLine("--These are the construction stages--");

            foreach (String part in lista)
            {
                Console.WriteLine(part);
            }

        }

    }
}
