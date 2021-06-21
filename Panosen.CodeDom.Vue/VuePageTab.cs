using Panosen.CodeDom.Tag.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// tab项
    /// </summary>
    public class VuePageTab
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
        /// 路由名称
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// 路由路径
        /// </summary>
        public string RoutePath { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string PageRouteName { get; set; }

        /// <summary>
        /// 路由路径
        /// </summary>
        public string PageRoutePath { get; set; }

        /// <summary>
        /// 组件
        /// </summary>
        public VueComponent Component { get; set; }
    }
}
