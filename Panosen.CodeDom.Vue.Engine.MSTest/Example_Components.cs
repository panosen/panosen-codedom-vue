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
    public class Example_Components
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
        components: {
            'layout': Layout,
            'layout2': Layout
        }
    }
</script>
";
        }

        public CodeScript GetData()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddComponent("layout", "Layout");
            codeScript.AddComponent("layout2", "Layout");

            return codeScript;
        }
    }
}
