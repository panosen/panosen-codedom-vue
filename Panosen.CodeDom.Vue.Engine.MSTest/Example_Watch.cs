using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Panosen.CodeDom.JavaScript;

namespace Panosen.CodeDom.Vue.Engine.MSTest
{
    [TestClass]
    public class Example_Watch
    {
        [TestMethod]
        public void Test()
        {
            var codeScript = GetData();

            var actual = codeScript.TransformText();

            var expected = PrepareExpected();

            Assert.AreEqual(expected, actual);
        }

        private string PrepareExpected()
        {
            return @"<script>
    export default {
        watch: {
            formValida: function () {
                this.ok = 123;
                this.ok = 123;
            },
            formValida2: function () {
                this.ok2 = 1232;
            }
        }
    }
</script>
";
        }

        public CodeScript GetData()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddWatch("formValida")
                .StepStatement("this.ok = 123;")
                .StepStatement("this.ok = 123;");
            codeScript.AddWatch("formValida2")
                .StepStatement("this.ok2 = 1232;");

            return codeScript;
        }
    }
}
