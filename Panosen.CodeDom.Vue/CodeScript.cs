using Panosen.CodeDom;
using Panosen.CodeDom.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    /// <summary>
    /// CodeScript
    /// </summary>
    public class CodeScript : Code
    {
        /// <summary>
        /// name: ${Name}
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// imports 节点
        /// </summary>
        public Dictionary<string, string> Imports { get; set; }

        /// <summary>
        /// components 节点
        /// </summary>
        public Dictionary<string, string> Components { get; set; }

        /// <summary>
        /// props 节点
        /// </summary>
        public Dictionary<string, VueProp> PropMap { get; set; }

        /// <summary>
        /// data 节点
        /// </summary>
        public SortedDataObject DataObject { get; set; }

        /// <summary>
        /// mounted 节点
        /// </summary>
        public CodeMethod Mounted { get; set; }

        /// <summary>
        /// created 节点
        /// </summary>
        public CodeMethod Created { get; set; }

        /// <summary>
        /// watch 节点
        /// </summary>
        public Dictionary<string, CodeMethod> Watches { get; set; }

        /// <summary>
        /// methods 节点
        /// </summary>
        public Dictionary<string, CodeMethod> Methods { get; set; }

        /// <summary>
        /// computed 节点
        /// </summary>
        public Dictionary<string, CodeMethod> Computeds { get; set; }
    }
}
