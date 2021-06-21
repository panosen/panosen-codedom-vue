using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// 菜单项
    /// </summary>
    public class VueMenuItem
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 文字
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 路由
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// 子菜单
        /// </summary>
        public List<VueMenuItem> Children { get; set; }
    }
}
