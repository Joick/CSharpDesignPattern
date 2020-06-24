using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    /// <summary>
    /// 忍者对象
    /// </summary>
    public class NinjaObj: BaseObj
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 面具
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// 武器
        /// </summary>
        public string Weapons { get; set; }

        public override BaseObj Clone()
        {
            return this.CopyByReflection();
        }
    }
}
