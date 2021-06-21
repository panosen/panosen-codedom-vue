using Panosen.CodeDom.Css.Engine;
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
        /// GenerateData
        /// </summary>
        public void GenerateData(SortedDataObject dataObject, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (dataObject == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(KEYWORD_DATA)
                .Write(Marks.COLON).Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACKET).Write(Marks.RIGHT_BRACKET).Write(Marks.WHITESPACE)
                .Write(Marks.EQUAL).Write(Marks.GREATER_THAN).Write(Marks.WHITESPACE).Write(Marks.LEFT_BRACKET);

            new JsCodeEngine().GenerateSortedDataObject(dataObject, codeWriter, new JavaScript.Engine.GenerateOptions
            {
                IndentSize = options.IndentSize
            }, false);

            codeWriter.Write(Marks.RIGHT_BRACKET);
        }
    }
}
