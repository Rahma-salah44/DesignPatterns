using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{

    //inheritance and composition
    internal class AbstractDecrator : Component
    {

        protected Component com;

        public void SetTheComponent(Component component)
        {
            com = component;
        }
        public override void MakeHouse()
        {
            if (com != null)
            {
                com.MakeHouse();
            }
        }
    }
}
