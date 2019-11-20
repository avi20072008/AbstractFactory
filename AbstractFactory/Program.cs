using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactory.AbstractFactoryCloths;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClothsFactory is abstract class so we cannot create object. Just use reference variable.
            ClothsFactory factory = new FactoryElegent(); // runtime polymorphism.
            var _shirt = factory.CreateShirt();
            var _trouser = factory.CreateTrouser();

            Console.WriteLine($"Today I am wearing {_shirt.getShirt()}  & {_trouser.getTrouser()}");
           
            Console.ReadLine();
        }
    }
}
