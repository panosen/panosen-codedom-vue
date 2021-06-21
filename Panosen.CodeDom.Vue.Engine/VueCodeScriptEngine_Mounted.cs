using Panosen.CodeDom.JavaScript;
using Panosen.CodeDom.JavaScript.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    partial class VueCodeScriptEngine
    {
        /// <summary>
        /// GenerateMounted
        /// </summary>
        public void GenerateMounted(CodeMethod codeMethod, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeMethod == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(KEYWORD_MOUNTED).Write(Marks.COLON).Write(Marks.WHITESPACE);

            new JsCodeEngine().GenerateCodeMethod(codeMethod, codeWriter, new JavaScript.Engine.GenerateOptions
            {
                IndentSize = options.IndentSize
            }, endWithNewLine: false);
        }
    }
}
