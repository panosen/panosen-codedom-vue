using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Panosen.CodeDom.Vue.Engine.MSTest
{
    [TestClass]
    public class Example_Props
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
        props: {
            name: {
                type: String,
                required: true
            },
            age: Number
        }
    }
</script>
";
        }

        public CodeScript GetData()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddProp("name", new VueProp { Type = "String", Required = true });
            codeScript.AddProp("age", new VueProp { Type = "Number" });

            return codeScript;
        }
    }
}
