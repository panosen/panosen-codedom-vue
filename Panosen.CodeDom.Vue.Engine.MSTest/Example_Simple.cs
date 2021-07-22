using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Panosen.CodeDom.Tag;
using Panosen.CodeDom.Css;

namespace Panosen.CodeDom.Vue.Engine.MSTest
{
    [TestClass]
    public class Example_Simple
    {
        [TestMethod]
        public void Test()
        {
            VueCodeFile vueCodeFile = new VueCodeFile();
            vueCodeFile.Template = PrepareTemplate();
            vueCodeFile.Script = PrepareCodeScript();
            vueCodeFile.Style = PrepareStyle();

            var actual = vueCodeFile.TransformText();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"<template>
    <div class=""simple"">
        <p>this is a test.</p>
    </div>
</template>

<script>
    export default {
        components: {
            'layout': Layout,
            'layout2': Layout
        }
    }
</script>

<style>
    a {
        margin: 10px;
    }
</style>";
        }

        private Component PrepareTemplate()
        {
            var component = new BasicComponent().AddCssClass("simple");
            component.AddChild<BasicComponent>("p").SetContent("this is a test.");
            return component;
        }

        public CodeScript PrepareCodeScript()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddComponent("layout", "Layout");
            codeScript.AddComponent("layout2", "Layout");

            return codeScript;
        }

        public CodeStyle PrepareStyle()
        {
            var style = new CodeStyle();

            style.AddCss("a")
                .SetMargin("10px");

            return style;
        }
    }
}
