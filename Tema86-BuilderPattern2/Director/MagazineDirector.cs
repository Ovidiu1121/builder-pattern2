using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema86_BuilderPattern2.builder;
using Tema86_BuilderPattern2.model;

namespace Tema86_BuilderPattern2.Director
{
    public class MagazineDirector : Director
    {
        public override Magazine instruct(IMagazineBuilder builder)
        {

            builder.addMagazineName();
            builder.addCityAddress();
            builder.buyPlace();
            builder.buildStructure();
            builder.buyStock();
            builder.hireSeller();

            return builder.getMagazine();

        }
    }
}
