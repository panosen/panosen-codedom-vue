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
        /// GenerateImport
        /// </summary>
        /// <param name="imports"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateImport(Dictionary<string, string> imports, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (imports == null || imports.Count == 0) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            foreach (var item in imports)
            {
                codeWriter.Write(options.IndentString).Write(KEYWORD_IMPORT).Write(Marks.WHITESPACE).Write(item.Key).Write(Marks.WHITESPACE);

                codeWriter.Write(KEYWORD_FROM).Write(Marks.WHITESPACE);
                
                codeWriter.Write(Marks.SINGLE_QUOTATION).Write(item.Value).Write(Marks.SINGLE_QUOTATION).Write(Marks.SEMICOLON);

                codeWriter.WriteLine();
            }

            codeWriter.WriteLine();
        }
    }
}
