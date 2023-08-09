using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema86_BuilderPattern2.builder;
using Tema86_BuilderPattern2.model;

namespace Tema86_BuilderPattern2.concreteBuilder
{
    public class MagazineBuilder : IMagazineBuilder
    {
        Magazine magazine;

        public MagazineBuilder()
        {
            magazine=new Magazine("Jumbo", "Bucharest"); 
        }

        public void addCityAddress()
        {
            magazine.add("The magazine will be in "+this.magazine.city);
        }

        public void addMagazineName()
        {
            magazine.add("Adding the magazine name: "+this.magazine.name);
        }

        public void buildStructure()
        {
            magazine.add("Builduing the structure");
        }

        public void buyPlace()
        {
            magazine.add("Buying a spot where the magazine will be placed");
        }

        public void buyStock()
        {
            magazine.add("Buying products so they can be put up for sale");
        }

        public Magazine getMagazine()
        {
            return this.magazine;
        }

        public void hireSeller()
        {
            magazine.add("Hiring a seller");
        }
    }
}
