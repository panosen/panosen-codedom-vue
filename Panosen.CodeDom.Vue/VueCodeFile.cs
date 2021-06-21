using Panosen.CodeDom.Tag;
using System;
using System.Collections.Generic;
using System.Text;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// vue code file
    /// </summary>
    public class VueCodeFile
    {
        /// <summary>
        /// template 的子节点
        /// </summary>
        public Component Template { get; set; }

        /// <summary>
        /// script 节点
        /// </summary>
        public CodeScript Script { get; set; }

        /// <summary>
        /// style 节点
        /// </summary>
        public CodeStyle Style { get; set; }
    }
}
