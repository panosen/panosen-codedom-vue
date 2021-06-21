using Panosen.CodeDom.JavaScript;
using Panosen.CodeDom.JavaScript.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    public partial class VueCodeScriptEngine
    {
        private const string KEYWORD_IMPORT = "import";
        private const string KEYWORD_COMPONENTS = "components";
        private const string KEYWORD_PROPS = "props";
        private const string KEYWORD_DATA = "data";
        private const string KEYWORD_COMPUTED = "computed";
        private const string KEYWORD_WATCH = "watch";
        private const string KEYWORD_MOUNTED = "mounted";
        private const string KEYWORD_CREATED = "created";
        private const string KEYWORD_METHODS = "methods";

        private const string KEYWORD_FROM = "from";

        /// <summary>
        /// GenerateScript
        /// </summary>
        public void GenerateScript(CodeScript codeScript, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (codeScript == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.WriteLine("<script>");
            options.PushIndent();

            GenerateImport(codeScript.Imports, codeWriter, options);

            codeWriter.Write(options.IndentString).WriteLine("export default {");
            options.PushIndent();

            var first = true;

            if (!string.IsNullOrEmpty(codeScript.Name))
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                codeWriter.Write(options.IndentString).WriteLine($"name: '{codeScript.Name}',");
                codeWriter.Write(options.IndentString).WriteLine("install(Vue) {");
                codeWriter.Write(options.IndentString).Write(options.TabString).WriteLine("Vue.component(this.name, this);");
                codeWriter.Write(options.IndentString).Write("}");
            }

            if (codeScript.Components != null && codeScript.Components.Count > 0)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateComponents(codeScript.Components, codeWriter, options);
            }

            if (codeScript.PropMap != null && codeScript.PropMap.Count > 0)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateProps(codeScript.PropMap, codeWriter, options);
            }

            if (codeScript.DataObject != null)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateData(codeScript.DataObject, codeWriter, options);
            }

            if (codeScript.Computeds != null && codeScript.Computeds.Count > 0)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateComputed(codeScript.Computeds, codeWriter, options);
            }

            if (codeScript.Watches != null && codeScript.Watches.Count > 0)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateWatch(codeScript.Watches, codeWriter, options);
            }

            if (codeScript.Mounted != null)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateMounted(codeScript.Mounted, codeWriter, options);
            }

            if (codeScript.Created != null)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateCreated(codeScript.Created, codeWriter, options);
            }

            if (codeScript.Methods != null && codeScript.Methods.Count > 0)
            {
                InsertCommaBeforeBlock(codeWriter, ref first);
                GenerateMethods(codeScript.Methods, codeWriter, options);
            }

            if (!first)
            {
                codeWriter.WriteLine();
            }

            options.PopIndent();
            codeWriter.Write(options.IndentString).WriteLine("}");

            options.PopIndent();
            codeWriter.WriteLine("</script>");
        }

        private static void InsertCommaBeforeBlock(CodeWriter codeWriter, ref bool first)
        {
            if (!first)
            {
                codeWriter.WriteLine(Marks.COMMA);
            }

            first = false;
        }

        private void HelpGenerateMethods(string keyword, Dictionary<string, CodeMethod> methods, CodeWriter codeWriter, GenerateOptions options = null)
        {
            if (methods == null) { return; }
            if (codeWriter == null) { return; }
            options = options ?? new GenerateOptions();

            codeWriter.Write(options.IndentString).Write(keyword).Write(Marks.COLON).Write(Marks.WHITESPACE).WriteLine(Marks.LEFT_BRACE);

            if (methods.Count > 0)
            {
                options.PushIndent();

                var enumerator = methods.GetEnumerator();
                var moveNext = enumerator.MoveNext();
                while (moveNext)
                {
                    var item = enumerator.Current;

                    codeWriter.Write(options.IndentString).Write(item.Key).Write(Marks.COLON).Write(Marks.WHITESPACE);

                    new JsCodeEngine().GenerateCodeMethod(item.Value, codeWriter, new JavaScript.Engine.GenerateOptions
                    {
                        IndentSize = options.IndentSize
                    }, endWithNewLine: false);

                    moveNext = enumerator.MoveNext();
                    if (moveNext)
                    {
                        codeWriter.Write(Marks.COMMA);
                    }

                    codeWriter.WriteLine();
                }

                options.PopIndent();
            }

            codeWriter.Write(options.IndentString).Write(Marks.RIGHT_BRACE);
        }
    }
}
