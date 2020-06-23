using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class MacPcFactory : BasePcFactory
    {
        public BaseMouse CreateMouseFactory()
        {
            return new MacMouse();
        }

        public BaseKeyboard CreateKeyboardFactory()
        {
            return new MacKeyboard();
        }
    }
}
