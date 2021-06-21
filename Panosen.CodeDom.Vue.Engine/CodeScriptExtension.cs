using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    /// <summary>
    /// CodeScriptExtension
    /// </summary>
    public static class CodeScriptExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        /// <param name="codeScript"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string TransformText(this CodeScript codeScript, GenerateOptions options = null)
        {
            StringBuilder builder = new StringBuilder();

            new VueCodeScriptEngine().GenerateScript(codeScript, new System.IO.StringWriter(builder));

            return builder.ToString();
        }
    }
}
