using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    /// <summary>
    /// VueCodeFileEngine
    /// </summary>
    public partial class VueCodeFileEngine
    {
        /// <summary>
        /// GenerateCodeFile
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateCodeFile(VueCodeFile codeFile, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeFile == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            new VueCodeTemplateEngine().GenerateTemplate(codeFile, codeWriter, options);

            if (codeFile.Template != null || codeFile.Template != null)
            {
                codeWriter.WriteLine();
            }

            new VueCodeScriptEngine().GenerateScript(codeFile.Script, codeWriter, options);

            if ((codeFile.Template != null || codeFile.Template != null || codeFile.Script != null) && codeFile.Style != null)
            {
                codeWriter.WriteLine();
            }

            new VueCodeStyleEngine().GenerateStyle(codeFile.Style, codeWriter, options);
        }
    }
}
