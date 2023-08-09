using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema86_BuilderPattern2.model;
using Tema86_BuilderPattern2.builder;

namespace Tema86_BuilderPattern2.Director
{
    public abstract class Director
    {
        public abstract Magazine instruct(IMagazineBuilder builder);

    }
}
