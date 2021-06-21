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
    public class Example_Data
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
        data: () => ({
            basic1: {
                age: 12
            },
            basic2: {
                name: tom,
                age: 12
            },
            boolValue: true,
            intValue: 124,
            score1: [{
                math: 123,
                english: 97
            }],
            score2: [{}, {}],
            stringValue: 123
        })
    }
</script>
";
        }

        public CodeScript GetData()
        {
            CodeScript codeScript = new CodeScript();

            codeScript.AddDataValue("stringValue", "123");
            codeScript.AddDataValue("intValue", 124);
            codeScript.AddDataValue("boolValue", true);

            codeScript.AddDataObject("basic1")
                .AddDataValue("age", 12);
            codeScript.AddDataObject("basic2")
                .AddDataValue("name", "tom")
                .AddDataValue("age", 12);

            codeScript.AddDataArray("score1").AddDataObject(new DataObject().AddDataValue("math", "123").AddDataValue("english", 97));
            codeScript.AddDataArray("score2").AddDataObject(new DataObject()).AddDataObject(new DataObject());

            return codeScript;
        }
    }
}
