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
    public class Example_Imports
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
    import Layout from 'savory-canos-vuetify-component/components/Layout.vue';

    export default {
    }
</script>
";
        }

        public CodeScript GetData()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddImport("Layout", "savory-canos-vuetify-component/components/Layout.vue");

            return codeScript;
        }
    }
}
