using Panosen.CodeDom.Css;
using Panosen.CodeDom.Css.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    /// <summary>
    /// VueCodeStyleEngine
    /// </summary>
    public class VueCodeStyleEngine
    {
        /// <summary>
        /// GenerateStyle
        /// </summary>
        /// <param name="codeStyle"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateStyle(CodeStyle codeStyle, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeStyle == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.WriteLine("<style>");

            new CssCodeEngine().Generate(codeStyle.CssList, codeWriter, new GenerationOptions
            {
                IndentSize = 1
            });

            codeWriter.Write("</style>");
        }
    }
}
