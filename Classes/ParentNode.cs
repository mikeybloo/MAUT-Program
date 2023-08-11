using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUT.Classes {
    public class ParentNode : INode {
        public string name { get; set; }
        public double value { get; set; }
        public double weight { get; set; }
        public double utilityScore { get; set; }
        public List<INode> childNodes { get; set; } = new List<INode>();
        public ParentNode parentNode { get; set; }

        public ParentNode() { }

        public ParentNode(string name, double value, double weight, double utilityScore = 0) {
            this.name = name;
            this.value = value;
            this.weight = weight;
            this.utilityScore = utilityScore;
        }

        public double weightApplication() {
            return this.value * this.weight;
        }

        public void setValueByTextValues(string value) { }

        public void setUtility() {
            this.utilityScore = 0;
            foreach (INode n in this.childNodes) {
                n.setUtility();
            }

            double sum = 0;
            for (int i = 0; i < this.childNodes.Count; i++) {
                sum += this.childNodes[i].weightApplication();
            }

            this.utilityScore = sum;
        }
    }
}