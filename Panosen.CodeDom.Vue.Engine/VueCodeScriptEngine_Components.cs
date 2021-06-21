using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    partial class VueCodeScriptEngine
    {
        public void GenerateComponents(Dictionary<string, string> components, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (components == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(KEYWORD_COMPONENTS)
                .Write(Marks.COLON).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            var enumerator = components.GetEnumerator();
            var moveNext = enumerator.MoveNext();
            while (moveNext)
            {
                var item = enumerator.Current;

                codeWriter.Write(options.IndentString).Write($"'{item.Key}': {item.Value}");

                moveNext = enumerator.MoveNext();
                if (moveNext)
                {
                    codeWriter.Write(Marks.COMMA);
                }

                codeWriter.WriteLine();
            }

            options.PopIndent();
            codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
        }
    }
}
