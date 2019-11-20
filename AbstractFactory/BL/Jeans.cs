using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interface;

namespace AbstractFactory.BL
{
    public class Jeans : ITrouser
    {   
        public string getTrouser()
        {
            return "Jeans";
        }
    }
}
