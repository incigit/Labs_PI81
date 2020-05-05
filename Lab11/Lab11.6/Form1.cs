using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11._6
{
	public partial class Form1 : Form
	{
		private Dictionary<string, string> Descriptions { get; set; }
		public Form1()
		{
			InitializeComponent();
			Descriptions = new Dictionary<string, string>();
		}


		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			if (e.Node.Level == 3)
			{
				textBox1.Text = Descriptions[e.Node.Name];
				textBox1.Refresh();
			}
			else
			{
				textBox1.Text = String.Empty;
				textBox1.Refresh();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			treeView1.SelectedNode.Remove();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox3.Text.Length == 0) return;
			if (treeView1.SelectedNode.Level == 2)
			{
				Descriptions.Add(textBox3.Text, textBox2.Text);
			}

			treeView1.SelectedNode.Nodes.Add(new TreeNode(textBox3.Text){Name = textBox3.Text});
		}
	}
}
