using Panosen.CodeDom.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue.Engine
{
    partial class VueCodeScriptEngine
    {
        public void GenerateComputed(Dictionary<string, CodeMethod> methods, CodeWriter codeWriter, GenerateOptions options = null)
        {
            HelpGenerateMethods(KEYWORD_COMPUTED, methods, codeWriter, options);
        }
    }
}
