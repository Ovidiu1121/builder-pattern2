using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema86_BuilderPattern2.model;

namespace Tema86_BuilderPattern2.builder
{
    public interface IMagazineBuilder
    {
        void addMagazineName();
        void addCityAddress();
        void buyPlace();
        void buildStructure();
        void buyStock();
        void hireSeller();
        Magazine getMagazine();
    }
}
