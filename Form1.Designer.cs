using MAUT.Classes;

namespace MAUT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public List<ParentNode> parentNodeList = new List<ParentNode>();
        public List<ChildNode> childNodeList = new List<ChildNode>();
        public List<Alternative> alternativeList = new List<Alternative>();
        public ParentNode rootNode;

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Label label1;
        private TreeView treeView1;
        private TabPage tabPage2;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox textBox5;
        private TextBox textBox4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private Button button3;
        private Label label3;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox6;
        private Button button4;
        private Button button5;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox textBox7;
        private Button button6;
        private Button button7;
        private TabPage tabPage3;
        private DataGridView dataGridView2;
        private Label label10;
        private Button button8;
        private Button button9;
    }
}