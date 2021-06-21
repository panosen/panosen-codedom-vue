using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    partial class VueCodeScriptEngine
    {
        public void GenerateProps(Dictionary<string, VueProp> propMap, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (propMap == null || propMap.Count == 0)
            {
                return;
            }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(KEYWORD_PROPS).Write(Marks.COLON).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);
            options.PushIndent();

            var enumerator = propMap.GetEnumerator();
            var moveNext = enumerator.MoveNext();
            while (moveNext)
            {
                var item = enumerator.Current;

                codeWriter.Write(options.IndentString).Write(item.Key).Write(Marks.COLON).Write(Marks.WHITESPACE);

                if (item.Value.Required)
                {
                    codeWriter.WriteLine(Marks.LEFT_BRACE);
                    options.PushIndent();

                    codeWriter.Write(options.IndentString).Write("type").Write(Marks.COLON).Write(Marks.WHITESPACE).Write(item.Value.Type).WriteLine(Marks.COMMA);
                    codeWriter.Write(options.IndentString).Write("required").Write(Marks.COLON).Write(Marks.WHITESPACE).Write("true").WriteLine();

                    options.PopIndent();
                    codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
                }
                else
                {
                    codeWriter.Write(item.Value.Type);
                }

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
