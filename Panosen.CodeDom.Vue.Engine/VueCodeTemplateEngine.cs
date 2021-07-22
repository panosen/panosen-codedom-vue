using Panosen.CodeDom.Tag;
using Panosen.CodeDom.Tag.Core;
using Panosen.CodeDom.Tag.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    /// <summary>
    /// VueCodeTemplateEngine
    /// </summary>
    public class VueCodeTemplateEngine
    {
        /// <summary>
        /// GenerateTemplate
        /// </summary>
        /// <param name="codeFile"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateTemplate(VueCodeFile codeFile, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeFile == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.WriteLine("<template>");

            if (codeFile.Template != null)
            {
                new TagEngineCore().Generate(codeFile.Template, codeWriter, new Tag.Engine.GenerateOptions
                {
                    IndentSize = 1
                });
                codeWriter.WriteLine();
            }

            codeWriter.WriteLine("</template>");
        }
    }
}
