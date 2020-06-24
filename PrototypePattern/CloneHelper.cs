using System;
using System.Reflection;

namespace PrototypePattern
{
    public static class CloneHelper
    {
        public static T CopyByReflection<T>(this T obj)
        {
            if (obj is null || obj is string || obj.GetType().IsValueType)
            {
                return obj;
            }

            var retval = Activator.CreateInstance(obj.GetType());
            FieldInfo[] fields = obj
                .GetType()
                .GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (var fieldInfo in fields)
            {
                try
                {
                    fieldInfo.SetValue(retval, CopyByReflection(fieldInfo.GetValue(obj)));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return (T)retval;
        }
    }
}
