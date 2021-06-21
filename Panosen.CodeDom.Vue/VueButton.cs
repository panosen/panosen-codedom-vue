using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    public class VueButton
    {
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 按钮的用途 link route click
        /// </summary>
        public string Usage { get; set; }

        /// <summary>
        /// 点击跳转的超链接
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// 路由名称
        /// </summary>
        public string RouteName { get; set; }

        /// <summary>
        /// 路由参数
        /// </summary>
        public Dictionary<string, string> RouteParams { get; set; }

        /// <summary>
        /// 点击执行的方法
        /// </summary>
        public string MethodName { get; set; }

        /// <summary>
        /// 点击方法的参数
        /// </summary>
        public List<string> MethodParams { get; set; }

        /// <summary>
        /// 执行的步骤
        /// </summary>
        public List<string> MethodSteps { get; set; }

        /// <summary>
        /// icon or text
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// 按钮图标
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// 按钮文字
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// 颜色 color="primary"
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 样式 outlined
        /// </summary>
        public string Style { get; set; }
    }
}
