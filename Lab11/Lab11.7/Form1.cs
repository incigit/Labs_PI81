using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11._7
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			DirectoryInfo directoryInfo = new DirectoryInfo(@"..\..\..");
			if (directoryInfo.Exists)
			{
				treeView1.AfterSelect += treeView1_AfterSelect;
				BuildTree(directoryInfo, treeView1.Nodes);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
		{
			TreeNode curNode = addInMe.Add(directoryInfo.Name);

			foreach (FileInfo file in directoryInfo.GetFiles())
			{
				curNode.Nodes.Add(file.FullName, file.Name);
			}
			foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
			{
				BuildTree(subdir, curNode.Nodes);
			}
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
