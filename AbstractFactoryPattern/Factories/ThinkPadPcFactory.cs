using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public class ThinkPadPcFactory : BasePcFactory
    {
        public BaseMouse CreateMouseFactory()
        {
            return new ThinkPadMouse(); ;
        }

        public BaseKeyboard CreateKeyboardFactory()
        {
            return new ThinkPadKeyboard();
        }
    }
}
