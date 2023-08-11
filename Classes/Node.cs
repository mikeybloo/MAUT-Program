using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUT.Classes {
    public interface INode {
        public string name { get; set; }
        public double value { get; set; }
        public double weight { get; set; }
        public double utilityScore { get; set; }

        public double weightApplication();

        public void setValueByTextValues(string value);

        public void setUtility();

        //public Node(string name, double value, double weight, double utilityScore = 0) {
        //    this.name = name;
        //    this.value = value;
        //    this.weight = weight;
        //    this.utilityScore = utilityScore;
        //}

        //public void setUtility() {
        //    double sum = 0;
        //    for (int i = 0; i < this.childNodes.Count; i++) {
        //        sum += this.childNodes[i].weightApplication();
        //    }

        //    this.utilityScore = sum;
        //}
    }
}
