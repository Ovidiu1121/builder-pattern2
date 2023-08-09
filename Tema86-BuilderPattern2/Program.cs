
using Tema86_BuilderPattern2.builder;
using Tema86_BuilderPattern2.concreteBuilder;
using Tema86_BuilderPattern2.Director;
using Tema86_BuilderPattern2.model;

class Program
{
    static void Main(string[] args)
    {

        IMagazineBuilder builder = new MagazineBuilder();
        Director director = new MagazineDirector();
        Magazine magazine=director.instruct(builder);
        magazine.displayShop();


    }
}

