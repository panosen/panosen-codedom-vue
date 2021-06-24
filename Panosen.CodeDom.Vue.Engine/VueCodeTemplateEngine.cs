using Panosen.CodeDom.Tag.Basic;
using Panosen.CodeDom.Tag.Basic.Engine;
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
                var tagEngineOptions = new Tag.Engine.GenerateOptions();
                tagEngineOptions.IndentSize = 1;
                tagEngineOptions.AddComponentEngine<BasicComponent>(new BasicComponentEngine());

                new TagEngineCore().Generate(codeFile.Template, codeWriter, tagEngineOptions);
                codeWriter.WriteLine();
            }

            codeWriter.WriteLine("</template>");
        }
    }
}
