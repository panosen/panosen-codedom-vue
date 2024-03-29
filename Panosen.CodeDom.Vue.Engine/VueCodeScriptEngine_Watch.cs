﻿using Panosen.CodeDom.JavaScript;
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
        /// GenerateWatch
        /// </summary>
        /// <param name="methods"></param>
        /// <param name="codeWriter"></param>
        /// <param name="options"></param>
        public void GenerateWatch(Dictionary<string, CodeMethod> methods, CodeWriter codeWriter, GenerateOptions options = null)
        {
            HelpGenerateMethods(KEYWORD_WATCH, methods, codeWriter, options);
        }
    }
}
