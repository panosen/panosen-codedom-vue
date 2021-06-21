using Panosen.CodeDom.Css;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// CodeStyleExtension
    /// </summary>
    public static class CodeStyleExtension
    {
        /// <summary>
        /// AddCss
        /// </summary>
        /// <param name="codeStyle"></param>
        /// <param name="codeCss"></param>
        /// <returns></returns>
        public static CodeStyle AddCss(this CodeStyle codeStyle, CodeCss codeCss)
        {
            if (codeStyle.CssList == null)
            {
                codeStyle.CssList = new List<CodeCss>();
            }

            codeStyle.CssList.Add(codeCss);

            return codeStyle;
        }

        /// <summary>
        /// AddCss
        /// </summary>
        /// <param name="codeStyle"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static CodeCss AddCss(this CodeStyle codeStyle, string name)
        {
            if (codeStyle.CssList == null)
            {
                codeStyle.CssList = new List<CodeCss>();
            }

            CodeCss codeCss = new CodeCss();
            codeCss.Name = name;

            codeStyle.CssList.Add(codeCss);

            return codeCss;
        }
    }
}
