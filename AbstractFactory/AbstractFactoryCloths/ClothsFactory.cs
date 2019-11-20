using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.AbstractFactoryCloths
{
    public abstract class ClothsFactory
    {
        public abstract IShirt CreateShirt();
        public abstract ITrouser CreateTrouser();
    }
}
