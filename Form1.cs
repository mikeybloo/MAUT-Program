using System.Diagnostics.Eventing.Reader;
using System.Xml.Linq;
using MAUT.Classes;

namespace MAUT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            button3 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            listBox1 = new ListBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            treeView1 = new TreeView();
            tabPage2 = new TabPage();
            button8 = new Button();
            label10 = new Label();
            button7 = new Button();
            label9 = new Label();
            textBox7 = new TextBox();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            button9 = new Button();
            dataGridView2 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1185, 581);
            tabControl1.TabIndex = 8;
            tabControl1.Selecting += tabControlChange;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(listBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(treeView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1177, 553);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parameters";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(319, 418);
            button5.Name = "button5";
            button5.Size = new Size(422, 23);
            button5.TabIndex = 36;
            button5.Text = "Apply";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(564, 336);
            button4.Name = "button4";
            button4.Size = new Size(145, 23);
            button4.TabIndex = 35;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 421);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(174, 23);
            textBox1.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 43);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 33;
            label8.Text = "Weight";
            label8.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(564, 61);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 32;
            textBox6.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(670, 307);
            button3.Name = "button3";
            button3.Size = new Size(39, 23);
            button3.TabIndex = 31;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(564, 289);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 30;
            label3.Text = "Value name";
            label3.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(564, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 29;
            textBox3.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(564, 174);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 28;
            label7.Text = "Values";
            label7.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(564, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 94);
            listBox1.TabIndex = 27;
            listBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(420, 129);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 26;
            label6.Text = "Value type";
            label6.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(420, 172);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(56, 19);
            radioButton2.TabIndex = 25;
            radioButton2.Text = "String";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            radioButton2.Click += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(420, 147);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 24;
            radioButton1.TabStop = true;
            radioButton1.Text = "Number";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            radioButton1.Click += radioButton1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 111);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 23;
            label5.Text = "Max Value";
            label5.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(564, 111);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 22;
            label4.Text = "Min Value";
            label4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(661, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(82, 23);
            textBox5.TabIndex = 21;
            textBox5.Visible = false;
            textBox5.WordWrap = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(564, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(81, 23);
            textBox4.TabIndex = 20;
            textBox4.Visible = false;
            textBox4.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 43);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 17;
            label2.Text = "Name";
            label2.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 13;
            textBox2.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(6, 451);
            button2.Name = "button2";
            button2.Size = new Size(238, 27);
            button2.TabIndex = 11;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(186, 418);
            button1.Name = "button1";
            button1.Size = new Size(58, 27);
            button1.TabIndex = 10;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "Parameters";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(6, 26);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(238, 374);
            treeView1.TabIndex = 8;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1177, 553);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alternatives";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(48, 42);
            button8.Name = "button8";
            button8.Size = new Size(188, 23);
            button8.TabIndex = 6;
            button8.Text = "Generate table";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 80);
            label10.Name = "label10";
            label10.Size = new Size(188, 15);
            label10.TabIndex = 5;
            label10.Text = "Insert alternatives and their values:";
            // 
            // button7
            // 
            button7.Location = new Point(48, 395);
            button7.Name = "button7";
            button7.Size = new Size(205, 23);
            button7.TabIndex = 4;
            button7.Text = "Delete Alternative";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(48, 319);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 3;
            label9.Text = "Alternatives:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(48, 337);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(205, 23);
            textBox7.TabIndex = 2;
            // 
            // button6
            // 
            button6.Location = new Point(48, 366);
            button6.Name = "button6";
            button6.Size = new Size(205, 23);
            button6.TabIndex = 1;
            button6.Text = "Add Alternative";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(48, 98);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1081, 203);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(dataGridView2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1177, 553);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Utility table";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(28, 40);
            button9.Name = "button9";
            button9.Size = new Size(149, 23);
            button9.TabIndex = 1;
            button9.Text = "Generate utility scores";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(28, 69);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(1117, 334);
            dataGridView2.TabIndex = 0;
            // 
            // Form1
            // 
            ClientSize = new Size(1209, 605);
            Controls.Add(tabControl1);
            Name = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                if (treeView1.Nodes.Count == 0)
                {
                    treeView1.Nodes.Add("RootNode");

                    rootNode = new ParentNode("RootNode", 0.0, 0.0);
                }
                else
                {
                    MessageBox.Show("There can only be 1 root node");
                }
            }
            else
            {
                if (treeView1.SelectedNode.Nodes.Count < 6)
                {
                    if (String.IsNullOrEmpty(textBox1.Text))
                    {
                        MessageBox.Show("Please enter a valid name!");
                    }
                    else
                    {
                        if (nameChecker(textBox1.Text))
                        {
                            treeView1.SelectedNode.Nodes.Add($"{textBox1.Text}");

                            ChildNode child = new ChildNode(textBox1.Text, 0.0, 0.0, 0, 0);


                            if (treeView1.SelectedNode.Text != "RootNode")
                            {
                                convertToParent(treeView1.SelectedNode.Text);

                                child.parentNode = parentNodeList[parentFinder(treeView1.SelectedNode.Text)];
                                childNodeList.Add(child);
                            }
                            else
                            {
                                child.parentNode = new ParentNode("RootNode", 0.0, 0.0);
                                childNodeList.Add(child);
                            }

                            addChildToParent(treeView1.SelectedNode.Text, textBox1.Text);
                        }
                        else
                        {
                            MessageBox.Show("Please insert a unique name");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Max 6 children per node!");
                }
            }

            logNodes();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                MessageBox.Show("Select a parameter!");
            }
            else
            {
                remover(treeView1.SelectedNode.Text);
                treeView1.SelectedNode.Remove();
            }

            logNodes();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label7.Visible = false;
            listBox1.Visible = false;
            button3.Visible = false;
            textBox3.Visible = false;
            label3.Visible = false;
            button4.Visible = false;

            int ind = fetchIndex(treeView1.SelectedNode.Text);
            listBox1.Items.Clear();
            if (childNodeList[ind].minValue == 0 && childNodeList[ind].maxValue == 0)
            {
                if (childNodeList[ind].textValues.Count > 0)
                {
                    for (int i = 0; i < childNodeList[ind].textValues.Count; i++)
                    {
                        listBox1.Items.Add(childNodeList[ind].textValues[i]);
                    }
                }
            }
            else
            {
                textBox4.Text = childNodeList[ind].minValue.ToString();
                textBox5.Text = childNodeList[ind].maxValue.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            label7.Visible = true;
            listBox1.Visible = true;
            button3.Visible = true;
            textBox3.Visible = true;
            label3.Visible = true;
            button4.Visible = true;

            int ind = fetchIndex(treeView1.SelectedNode.Text);
            listBox1.Items.Clear();
            if (childNodeList[ind].minValue == 0 && childNodeList[ind].maxValue == 0)
            {
                if (childNodeList[ind].textValues.Count > 0)
                {
                    for (int i = 0; i < childNodeList[ind].textValues.Count; i++)
                    {
                        listBox1.Items.Add(childNodeList[ind].textValues[i]);
                    }
                }
            }
            else
            {
                textBox4.Text = childNodeList[ind].minValue.ToString();
                textBox5.Text = childNodeList[ind].maxValue.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Please enter the name of a value!");
            }
            else
            {
                if (listBox1.Items.Count == 6)
                {
                    MessageBox.Show("Max 6 items allowed!");
                }
                else if (listBox1.Items.Contains(textBox3.Text))
                {
                    MessageBox.Show("Please enter a unique item!");
                }
                else
                {
                    listBox1.Items.Add($"{textBox3.Text}");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item do delete!");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            label2.Visible = true;
            label8.Visible = true;
            label6.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            textBox2.Visible = true;
            textBox6.Visible = true;
            button5.Visible = true;

            if (treeView1.SelectedNode.Text == "RootNode")
            {
                label4.Visible = false;
                label5.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                listBox1.Visible = false;
                button3.Visible = false;
                textBox3.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                button4.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                textBox2.ReadOnly = true;
                textBox2.Text = rootNode.name;
            }
            else if (treeView1.SelectedNode.Nodes.Count != 0)
            {
                label4.Visible = false;
                label5.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                label7.Visible = false;
                listBox1.Visible = false;
                button3.Visible = false;
                textBox3.Visible = false;
                label3.Visible = false;
                label6.Visible = false;
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                button4.Visible = false;
                label8.Visible = true;
                textBox6.Visible = true;
                textBox2.ReadOnly = false;

                textBox2.Text = parentNodeList[fetchIndex(treeView1.SelectedNode.Text)].name;
                textBox6.Text = parentNodeList[fetchIndex(treeView1.SelectedNode.Text)].weight.ToString();
            }
            else
            {
                textBox4.Text = "";
                textBox5.Text = "";
                radioButton1.Checked = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                label7.Visible = false;
                listBox1.Visible = false;
                button3.Visible = false;
                textBox3.Visible = false;
                label3.Visible = false;
                button4.Visible = false;
                textBox2.ReadOnly = false;

                int ind = fetchIndex(treeView1.SelectedNode.Text);
                textBox2.Text = childNodeList[ind].name;
                textBox6.Text = childNodeList[ind].weight.ToString();
                if (childNodeList[ind].minValue == 0 && childNodeList[ind].maxValue == 0)
                {
                    if (childNodeList[ind].textValues.Count > 0)
                    {
                        label4.Visible = false;
                        label5.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;
                        label7.Visible = true;
                        listBox1.Visible = true;
                        button3.Visible = true;
                        textBox3.Visible = true;
                        label3.Visible = true;
                        button4.Visible = true;
                        radioButton2.Checked = true;
                        listBox1.Visible = true;
                        for (int i = 0; i < childNodeList[ind].textValues.Count; i++)
                        {
                            listBox1.Items.Add(childNodeList[ind].textValues[i]);
                        }
                    }
                }
                else
                {
                    textBox4.Text = childNodeList[ind].minValue.ToString();
                    textBox5.Text = childNodeList[ind].maxValue.ToString();
                }
            }
        }

        public int fetchIndex(string name)
        {
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].name == name)
                {
                    return i;
                }
            }

            for (int i = 0; i < childNodeList.Count; i++)
            {
                if (childNodeList[i].name == name)
                {
                    return i;
                }
            }

            return -1;
        }

        public void childChecker()
        {
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].childNodes.Count == 0)
                {
                    convertToChild(parentNodeList[i].name);
                }
            }
        }

        public void remover(string name)
        {
            for (int i = 0; i < childNodeList.Count; i++)
            {
                if (childNodeList[i].name == name)
                {
                    childNodeList.RemoveAt(i);
                    for (int j = 0; j < parentNodeList.Count; j++)
                    {
                        for (int k = 0; k < parentNodeList[j].childNodes.Count; k++)
                        {
                            if (name == parentNodeList[j].childNodes[k].name)
                            {
                                parentNodeList[j].childNodes.RemoveAt(k);
                            }
                        }
                    }
                }
            }

            childChecker();

            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].name == name)
                {
                    for (int j = 0; j < parentNodeList[i].childNodes.Count; j++)
                    {
                        for (int n = 0; n < childNodeList.Count; n++)
                        {
                            if (childNodeList[n].name == parentNodeList[i].childNodes[j].name)
                            {
                                childNodeList.RemoveAt(n);
                            }
                        }
                    }

                    parentNodeList.RemoveAt(i);
                }
            }
        }

        public int parentFinder(string name)
        {
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].name == name)
                {
                    return i;
                }
            }

            return -1;
        }

        public void convertToParent(string name)
        {
            bool chk = true;
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].name == name)
                {
                    chk = false;
                }
            }

            if (chk)
            {
                int childIndex = 0;
                for (int i = 0; i < childNodeList.Count; i++)
                {
                    if (childNodeList[i].name == name)
                    {
                        childIndex = i;
                    }
                }

                ParentNode parent = new ParentNode(name, 0.0, 0.0);

                parent.parentNode = childNodeList[childIndex].parentNode;

                childNodeList.RemoveAt(childIndex);
                parentNodeList.Add(parent);
            }
        }

        public void convertToChild(string name)
        {
            int parentIndex = 0;
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (parentNodeList[i].name == name)
                {
                    parentIndex = i;
                }
            }

            ChildNode child = new ChildNode(name, 0.0, 0.0, 0.0, 0.0);
            child.parentNode = parentNodeList[parentIndex].parentNode;

            parentNodeList.RemoveAt(parentIndex);
            childNodeList.Add(child);
        }

        public bool nameChecker(string name)
        {
            for (int i = 0; i < parentNodeList.Count; i++)
            {
                if (name == parentNodeList[i].name)
                {
                    return false;
                }
            }

            for (int i = 0; i < childNodeList.Count; i++)
            {
                if (name == childNodeList[i].name)
                {
                    return false;
                }
            }

            return true;
        }

        public void addChildToParent(string parentName, string childName)
        {
            for (int i = 0; i < childNodeList.Count; i++)
            {
                if (childName == childNodeList[i].name)
                {
                    ChildNode childNode = childNodeList[i];
                    if (parentName == "RootNode")
                    {
                        rootNode.childNodes.Add(childNode);
                    }
                    else
                    {
                        for (int j = 0; j < parentNodeList.Count; j++)
                        {
                            if (parentName == parentNodeList[j].name)
                            {
                                parentNodeList[j].childNodes.Add(childNode);
                            }
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (parentFinder(treeView1.SelectedNode.Text) >= 0)
            {
                button5ParentEdit(treeView1.SelectedNode.Text);
                MessageBox.Show("Parent edited");
            }
            else
            {
                button5ChildEdit(treeView1.SelectedNode.Text);
                MessageBox.Show("Child edited");
            }


            logNodes();
        }

        public void button5ParentEdit(string name)
        {
            //Name edit
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                for (int i = 0; i < parentNodeList.Count; i++)
                {
                    if (parentNodeList[i].name == name)
                    {
                        parentNodeList[i].name = textBox2.Text;
                        treeView1.SelectedNode.Text = textBox2.Text;
                    }
                }
            }

            //Weight edit
            Double num = 0;
            if (!Double.TryParse(textBox6.Text, out num))
            {
                MessageBox.Show("Please enter a double value!");
            }
            else
            {
                for (int i = 0; i < parentNodeList.Count; i++)
                {
                    if (parentNodeList[i].name == name)
                    {
                        parentNodeList[i].weight = Double.Parse(textBox6.Text);
                    }
                }
            }

            updateChildNodesOfParents();
        }

        public void tabControlChange(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {

            }
            else if (tabControl1.SelectedIndex == 2)
            {
                if (!checkDataValues())
                {
                    MessageBox.Show("Please check if the inserted values are correct!");
                    tabControl1.SelectedIndex = 1;
                    return;
                }
            }
            else if (tabControl1.SelectedIndex == 0)
            {
                DialogResult d = MessageBox.Show("Warning! Returning to this menu will completely reset all the values and alternatives you have set on the 2nd tab. Are you sure you want to proceed?", "Alert", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    tabControl1.SelectedIndex = 0;
                    alternativeList.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                }
                else if (d == DialogResult.No)
                {
                    tabControl1.SelectedIndex = 1;
                }
            }
        }

        //Generate page 3 table button
        private void button9_Click(object sender, EventArgs e)
        {
            fillPage3();
        }

        //Generate page 2 table button
        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            foreach (TreeNode n in recursiveTreeNodeIteration(treeView1.Nodes))
            {
                if (n.Text == "RootNode")
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = n.Text;
                    col.ReadOnly = true;
                    dataGridView1.Columns.Add(col);
                }
                else if (parentFinder(n.Text) >= 0)
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = n.Text;
                    col.ReadOnly = true;
                    dataGridView1.Columns.Add(col);
                }
                else
                {
                    if (childNodeDataType(n.Text) == "Text")
                    {
                        DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                        col.HeaderText = n.Text;
                        List<string> itemList = getTextValues(n.Text);

                        foreach (string s in itemList)
                        {
                            col.Items.Add(s);
                        }

                        dataGridView1.Columns.Add(col);
                    }
                    else if (childNodeDataType(n.Text) == "Int")
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.HeaderText = n.Text + "\n" + "Range: " + getMin(n.Text).ToString() + " - " + getMax(n.Text).ToString();
                        dataGridView1.Columns.Add(col);
                    }
                }
            }
        }

        public double getMin(string name) {
            foreach (ChildNode c in childNodeList) {
                if (c.name == name) {
                    return c.minValue;
                }
            }

            return -1;
        }

        public double getMax(string name) {
            foreach (ChildNode c in childNodeList) {
                if (c.name == name) {
                    return c.maxValue;
                }
            }

            return -1;
        }

        public IEnumerable<TreeNode> recursiveTreeNodeIteration(TreeNodeCollection nodes)
        {
            foreach (TreeNode n in nodes)
            {
                yield return n;

                foreach (var child in recursiveTreeNodeIteration(n.Nodes))
                {
                    yield return child;
                }
            }
        }

        public List<TreeNode> treeNodeEnumerableToList()
        {
            IEnumerable<TreeNode> nodes = recursiveTreeNodeIteration(treeView1.Nodes);
            List<TreeNode> list = new List<TreeNode>();
            foreach (TreeNode t in nodes)
            {
                list.Add(t);
            }

            return list;
        }

        public void fillPage3()
        {
            addValuesToAlternativeNodes();
            calculateUtilities();

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            //Adds columns first
            foreach (TreeNode t in recursiveTreeNodeIteration(treeView1.Nodes))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = t.Text;
                col.ReadOnly = true;
                dataGridView2.Columns.Add(col);
            }

            //Adding rows
            foreach (Alternative a in alternativeList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.ReadOnly = true;
                row.HeaderCell.Value = a.name;
                dataGridView2.Rows.Add(row);

                dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[0].Value = a.rootNode.utilityScore;

                List<TreeNode> nodes = treeNodeEnumerableToList();
                for (int i = 1; i < nodes.Count; i++)
                {
                    foreach (INode n in a.nodeList)
                    {
                        if (n.name == nodes[i].Text)
                        {
                            dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[i].Value = n.utilityScore;
                        }
                    }
                }
            }
        }

        //Verification of value insertion
        public bool checkDataValues()
        {
            bool answer = true;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    if (row.Cells.Count == 0 || dataGridView1.Columns.Count == 0 || dataGridView1.Rows.Count == 0)
                    {
                        answer = false;
                    } 

                    foreach (ChildNode c in childNodeList)
                    {
                        if (c.name == dataGridView1.Columns[i].HeaderText)
                        {
                            if (String.IsNullOrEmpty(row.Cells[i].Value.ToString()))
                            {
                                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                                cellStyle.BackColor = Color.Red;
                                row.Cells[i].Style = cellStyle;
                                answer = false;
                            } 
                                
                            //if(!rangeCheck(dataGridView1.Columns[i].HeaderText, row.Cells[i].Value.ToString())) {
                            //    DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                            //    cellStyle.BackColor = Color.Red;
                            //    row.Cells[i].Style = cellStyle;
                            //    answer = false;
                            //}
                        }
                    }
                }
            }

            return answer;
        }

        public bool rangeCheck(string name, string value) {
            double chk = Convert.ToDouble(value);
            Console.WriteLine($"Checking {name} and {value}");

            foreach (ChildNode c in childNodeList) {
                if (name == c.name) {
                    if(c.maxValue >= chk && c.minValue <= chk){
                        return true;
                    } else {
                        return false;
                    }
                }
            }

            return false;
        }

        //Taking values from the dataGridView1 and inserting them into the correct nodes
        public void addValuesToAlternativeNodes()
        {
            List<TreeNode> nodes = treeNodeEnumerableToList();
            for (int i = 0; i < alternativeList.Count; i++)
            {
                for (int k = 0; k < nodes.Count; k++)
                {
                    for (int j = 0; j < alternativeList[i].nodeList.Count; j++)
                    {
                        if (nodes[k].Text == alternativeList[i].nodeList[j].name)
                        {
                            if (alternativeList[i].nodeList[j].name != "RootNode")
                            {
                                if (parentFinder(alternativeList[i].nodeList[j].name) == -1)
                                {
                                    if (childNodeDataType(alternativeList[i].nodeList[j].name) == "Text")
                                    {
                                        alternativeList[i].nodeList[j].setValueByTextValues(dataGridView1.Rows[i].Cells[k].Value.ToString());
                                    }
                                    else if (childNodeDataType(alternativeList[i].nodeList[j].name) == "Int")
                                    {
                                        alternativeList[i].nodeList[j].value = Convert.ToDouble(dataGridView1.Rows[i].Cells[k].Value.ToString());
                                    }
                                }
                            }
                        }

                        //Console.WriteLine("\n");
                        //foreach (Alternative a in alternativeList)
                        //{
                        //    Console.WriteLine($"Alt name: {a.name}");
                        //    foreach (INode n in a.nodeList)
                        //    {
                        //        Console.WriteLine($"\t - Name: {n.name} Value: {n.value}");
                        //    }
                        //}
                    }
                }
            }
        }

        //Iterate thru tree nodes and call their setUtility() method in the correct order.
        public void calculateUtilities()
        {
            for (int i = 0; i < alternativeList.Count; i++)
            {
                //Create a list of tree nodes and iterate backwards to calculate utility score
                List<TreeNode> treeNodes = treeNodeEnumerableToList();
                for (int j = treeNodes.Count - 1; j >= 1; j--)
                {
                    foreach (INode n in alternativeList[i].nodeList)
                    {
                        if (n.name == treeNodes[j].Text)
                        {
                            n.setUtility();
                        }
                    }
                }

                alternativeList[i].rootNode.setUtility();
            }
        }

        //Retrieves the list of a nodes' text values
        public List<string> getTextValues(string name)
        {
            foreach (ChildNode c in childNodeList)
            {
                if (c.name == name)
                {
                    return c.textValues;
                }
            }

            return new List<string>();
        }

        //Method that returns "Text" if the data type of the child node is text-based and "Int" if its number-based.
        public string childNodeDataType(string name)
        {
            foreach (ChildNode n in childNodeList)
            {
                if (n.name == name)
                {
                    if (n.textValues.Count > 1)
                    {
                        return "Text";
                    }
                    else
                    {
                        return "Int";
                    }
                }
            }

            return "";
        }

        public void button5ChildEdit(string name)
        {
            //Name edit
            if (!String.IsNullOrEmpty(textBox2.Text))
            {
                for (int i = 0; i < childNodeList.Count; i++)
                {
                    if (childNodeList[i].name == name)
                    {
                        childNodeList[i].name = textBox2.Text;
                        treeView1.SelectedNode.Text = textBox2.Text;
                    }
                }
            }

            //Weight edit
            Double num = 0;
            if (!String.IsNullOrEmpty(textBox6.Text))
            {
                if (!Double.TryParse(textBox6.Text, out num))
                {
                    MessageBox.Show("Please enter a double value!");
                }
                else
                {
                    for (int i = 0; i < childNodeList.Count; i++)
                    {
                        if (childNodeList[i].name == name)
                        {
                            childNodeList[i].weight = Double.Parse(textBox6.Text);
                        }
                    }
                }
            }

            //Number min/max value edit
            if (radioButton1.Checked)
            {
                if (!String.IsNullOrEmpty(textBox4.Text) && !String.IsNullOrEmpty(textBox5.Text))
                {
                    if (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
                    {
                        MessageBox.Show("Please fill both the max and min text boxes!");
                    }
                    else
                    {
                        if (!Double.TryParse(textBox4.Text, out num) || !Double.TryParse(textBox5.Text, out num))
                        {
                            MessageBox.Show("Please enter a double value in the mix/max spaces!");
                        }
                        else
                        {
                            if (Double.Parse(textBox4.Text) >= Double.Parse(textBox5.Text) || Double.Parse(textBox4.Text) < 0)
                            {
                                MessageBox.Show("Please enter a valid min and max range! ");
                            }
                            else
                            {
                                for (int i = 0; i < childNodeList.Count; i++)
                                {
                                    if (childNodeList[i].name == name)
                                    {
                                        childNodeList[i].minValue = Double.Parse(textBox4.Text);
                                        childNodeList[i].maxValue = Double.Parse(textBox5.Text);
                                        childNodeList[i].textValues = new List<string>();
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //String value edit
            if (radioButton2.Checked)
            {
                if (listBox1.Items.Count > 0)
                {
                    if (listBox1.Items.Count == 1)
                    {
                        MessageBox.Show("Please enter more than 1 string value in the list!");
                    }
                    else
                    {
                        for (int i = 0; i < childNodeList.Count; i++)
                        {
                            if (childNodeList[i].name == name)
                            {
                                List<string> list = new List<string>();
                                foreach (object o in listBox1.Items)
                                {
                                    list.Add(o.ToString());
                                }

                                childNodeList[i].textValues = list;
                                childNodeList[i].minValue = 0;
                                childNodeList[i].maxValue = 0;
                            }
                        }
                    }
                }
            }

            updateChildNodesOfParents();
        }

        public void logNodes()
        {
            Console.Clear();
            Console.WriteLine("Parents:");
            foreach (ParentNode p in parentNodeList)
            {
                Console.WriteLine($"{p.name}, {p.value}, {p.weight}, Parent: {p.parentNode.name}");
                Console.WriteLine("Children:");
                foreach (ChildNode c in p.childNodes)
                {
                    Console.WriteLine($"\t {c.name}");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Children:");
            foreach (ChildNode p in childNodeList)
            {
                Console.WriteLine($"{p.name}, Value: {p.value}, Weight: {p.weight}, Min: {p.minValue}, Max: {p.maxValue}, Parent: {p.parentNode.name}");
                Console.WriteLine("String values:");
                foreach (string s in p.textValues)
                {
                    Console.WriteLine($"\t - {s}");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Alternatives:");
            foreach (Alternative a in alternativeList)
            {
                Console.WriteLine($"Name: {a.name}");
            }
        }

        //Adding alternatives
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                MessageBox.Show("Please generate a table first!");
            }
            else if (String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Insert the alternative name!");
            }
            else if (!alternativeAvailable(textBox7.Text))
            {
                MessageBox.Show("Select a unique alernative name!");
            }
            else
            {
                Alternative alt = new Alternative();
                alt.name = textBox7.Text;
                alt.rootNode = rootNode;
                foreach (ParentNode p in parentNodeList)
                {
                    alt.nodeList.Add(p);
                }

                foreach (ChildNode c in childNodeList)
                {
                    alt.nodeList.Add(c);
                }

                alternativeList.Add(alt);

                DataGridViewRow row = new DataGridViewRow();
                row.HeaderCell.Value = textBox7.Text;

                dataGridView1.Rows.Add(row);

                fillEmptyValues();
            }

            logNodes();
        }

        public void fillEmptyValues()
        {
            for (int i = 0; i < recursiveTreeNodeIteration(treeView1.Nodes).Count(); i++)
            {
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[i].Value = "";
            }
        }

        //Checker for unique alternative names
        public bool alternativeAvailable(string name)
        {
            foreach (Alternative a in alternativeList)
            {
                if (name == a.name)
                {
                    return false;
                }
            }

            return true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete!");
            }
            else
            {
                string name = dataGridView1.SelectedRows[0].HeaderCell.Value.ToString();
                foreach (Alternative a in alternativeList.ToList())
                {
                    if (a.name == name)
                    {
                        alternativeList.Remove(a);
                    }
                }
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }

            logNodes();
        }

        //Method that updates all INode objects in the childNodeList property of a ParentNode
        public void updateChildNodesOfParents()
        {
            foreach (ParentNode p in parentNodeList)
            {
                for (int i = 0; i < p.childNodes.Count; i++)
                {
                    //Replaces child nodes
                    foreach (ChildNode c in childNodeList)
                    {
                        if (p.childNodes[i].name == c.name)
                        {
                            p.childNodes.Remove(p.childNodes[i]);
                            p.childNodes.Add(c);
                        }
                    }

                    //Replaces parent nodes
                    foreach (ParentNode p2 in parentNodeList)
                    {
                        if (p.childNodes[i].name == p2.name)
                        {
                            p.childNodes.Remove(p.childNodes[i]);
                            p.childNodes.Add(p2);
                        }
                    }
                }
            }
        }


    }
}