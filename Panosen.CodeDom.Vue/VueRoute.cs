using Panosen.CodeDom.Tag.Vue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.CodeDom.Vue
{
    public class VueRoute
    {
        public string Path { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public VueComponent Component { get; set; }

        public bool LazyLoad { get; set; }

        public string Redirect { get; set; } = string.Empty;

        public List<VueRoute> Children { get; set; }
    }
}
