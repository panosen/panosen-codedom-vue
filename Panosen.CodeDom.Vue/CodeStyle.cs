using Panosen.CodeDom.Css;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// CodeStyle
    /// </summary>
    public class CodeStyle : Code
    {
        /// <summary>
        /// css
        /// </summary>
        public List<CodeCss> CssList { get; set; }
    }
}
