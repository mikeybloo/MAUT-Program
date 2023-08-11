using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUT.Classes
{
    public class Alternative
    {
        public string name {  get; set; }
        public List<INode> nodeList { get; set; } = new List<INode>();
        public ParentNode rootNode { get; set; }

        public Alternative() { }

        public Alternative(string name) {
            this.name = name;
        }
    }
}
