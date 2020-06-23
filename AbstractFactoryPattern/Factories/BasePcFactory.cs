using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryPattern.Products;

namespace AbstractFactoryPattern.Factories
{
    public interface BasePcFactory
    {
        BaseMouse CreateMouseFactory();
        BaseKeyboard CreateKeyboardFactory();
    }
}
