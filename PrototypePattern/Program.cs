using System;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ninja1 = new NinjaObj()
            {
                Name = "忍者1",
                Gender = "男",
                Mask = "般若",
                Weapons = "苦无"
            };

            var ninja2 = ninja1.Clone() as NinjaObj;

            Console.WriteLine($"ninja1.Name={ninja1.Name},ninja1.mask={ninja1.Mask},ninja1.weapon={ninja1.Weapons},ninja1.hashcode={ninja1.GetHashCode()}");
            Console.WriteLine($"ninja2.Name={ninja2.Name},ninja2.mask={ninja2.Mask},ninja2.weapon={ninja2.Weapons},ninja2.hashcode={ninja2.GetHashCode()}");
        }
    }
}
