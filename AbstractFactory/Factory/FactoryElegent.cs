using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BL;
using AbstractFactory.Interface;
using AbstractFactory.AbstractFactoryCloths;

namespace AbstractFactory.Factory
{
    class FactoryElegent : ClothsFactory
    {
        public override IShirt CreateShirt()
        {
            return new DressShirt();
        }
        public override ITrouser CreateTrouser()
        {
            return new DressTrouser();
        }
    }
}
