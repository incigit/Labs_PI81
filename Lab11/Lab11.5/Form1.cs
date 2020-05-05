using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11._5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//var university = new LinkedList<Node>();
			//university.AddLast(new Node("МНТУ"));
			//university.First(node => node.Data == "МНТУ").Children.AddLast(new Node("Факультет Економіки"));
			//university.First(node => node.Data == "МНТУ").Children
			//	.First(node => node.Data == "Факультет Економіки").Children.AddLast(new Node("Кафедра Міжнародної економіки"));
			//university.First(node => node.Data == "МНТУ").Children
			//	.First(node => node.Data == "Факультет Економіки").Children.AddLast(new Node("Фінанси."));
			//university.First(node => node.Data == "МНТУ").Children
			//	.First(node => node.Data == "Факультет Економіки").Children
			//	.First(node => node.Data == "Кафедра Міжнародної економіки").Children.AddLast(new Node("МЕ-81"));
			//university.First(node => node.Data == "МНТУ").Children
			//	.First(node => node.Data == "Факультет Економіки").Children
			//	.First(node => node.Data == "Фінанси").Children.AddLast(new Node("ФН-71"));
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Level == 3)
			{
				listBox1.Items.Clear();
				listBox1.DataSource = e.Node.Nodes;
				listBox1.Refresh();
			}
			else
			{
				listBox1.DataSource = null;
				listBox1.Refresh();
			}
			
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox1.Text));
		}

		private void button2_Click(object sender, EventArgs e)
		{
			treeView1.SelectedNode.Remove();
		}
	}
}