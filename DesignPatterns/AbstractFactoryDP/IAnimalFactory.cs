using AbstractFactoryDP.AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    internal interface IAnimalFactory
    {
        IDog GetDog();
        ITiger GetTiger();

    }
}
