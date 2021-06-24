using Panosen.CodeDom.Tag.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// 
    /// </summary>
    public class VueRoute
    {
        /// <summary>
        /// Path
        /// </summary>
        public string Path { get; set; } = string.Empty;

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Component
        /// </summary>
        public VueComponent Component { get; set; }

        /// <summary>
        /// LazyLoad
        /// </summary>
        public bool LazyLoad { get; set; }

        /// <summary>
        /// Redirect
        /// </summary>
        public string Redirect { get; set; } = string.Empty;

        /// <summary>
        /// Children
        /// </summary>
        public List<VueRoute> Children { get; set; }
    }
}
