using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUT.Classes {
    public class ChildNode : INode {
        public string name { get; set; }
        public double value { get; set; }
        public double weight { get; set; }
        public double utilityScore { get; set; }

        public ParentNode parentNode { get; set; } = new ParentNode();
        public List<string> textValues { get; set; } = new List<string>();
        public double maxValue { get; set; }
        public double minValue { get; set; }

        public ChildNode() { }

        public ChildNode(string name, double value, double weight, double maxValue, double minValue, double utilityScore = 0) {
            this.name = name;
            this.value = value;
            this.weight = weight;
            this.maxValue = maxValue;
            this.minValue = minValue;
            this.utilityScore = utilityScore;
        }        

        public void setValueByTextValues(string value) {
            this.value = (double)(Convert.ToDouble(this.textValues.IndexOf(value) + 1.0) / Convert.ToDouble(this.textValues.Count));
            this.maxValue = this.textValues.Count;
            this.minValue = 0;
        }

        public void setUtility() {
            this.utilityScore = Math.Round(((this.value - this.maxValue) / (this.minValue - this.maxValue)), 2);
        }

        public double weightApplication() {
            return Math.Round((this.utilityScore * this.weight), 2);
        }
    }
}