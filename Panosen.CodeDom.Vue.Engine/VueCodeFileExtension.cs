using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    /// <summary>
    /// VueCodeFileExtension
    /// </summary>
    public static class VueCodeFileExtension
    {
        /// <summary>
        /// TransformText
        /// </summary>
        /// <param name="vueCodeFile"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static string TransformText(this VueCodeFile vueCodeFile, GenerateOptions options = null)
        {
            var builder = new StringBuilder();

            new VueCodeFileEngine().GenerateCodeFile(vueCodeFile, builder, options);

            return builder.ToString();
        }
    }
}
