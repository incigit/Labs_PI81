namespace Lab11._5
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Петро Петренко");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("ME-81", new System.Windows.Forms.TreeNode[] {
            treeNode19});
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Кафедра Міжнародної економіки", new System.Windows.Forms.TreeNode[] {
            treeNode20});
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Іван Іванов");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Сергій Програміст");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("ФН-71", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Фінанси", new System.Windows.Forms.TreeNode[] {
            treeNode24});
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Факультет економіки", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode25});
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("МНТУ", new System.Windows.Forms.TreeNode[] {
            treeNode26});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			treeNode19.Name = "Node0";
			treeNode19.Text = "Петро Петренко";
			treeNode20.Name = "ME81";
			treeNode20.Text = "ME-81";
			treeNode21.Name = "MizhnEkonomic";
			treeNode21.Text = "Кафедра Міжнародної економіки";
			treeNode22.Name = "Node1";
			treeNode22.Text = "Іван Іванов";
			treeNode23.Name = "Node2";
			treeNode23.Text = "Сергій Програміст";
			treeNode24.Name = "FN71";
			treeNode24.Text = "ФН-71";
			treeNode25.Checked = true;
			treeNode25.Name = "Finance";
			treeNode25.Text = "Фінанси";
			treeNode26.Name = "EconomicFaculty";
			treeNode26.Text = "Факультет економіки";
			treeNode27.Checked = true;
			treeNode27.Name = "University";
			treeNode27.Text = "МНТУ";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode27});
			this.treeView1.Size = new System.Drawing.Size(256, 426);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(274, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(277, 186);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// form1BindingSource
			// 
			this.form1BindingSource.DataSource = typeof(Lab11._5.Form1);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(274, 393);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 45);
			this.button1.TabIndex = 2;
			this.button1.Text = "Додати вузол";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(357, 393);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(77, 45);
			this.button2.TabIndex = 2;
			this.button2.Text = "Видалити вузол";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(274, 367);
			this.textBox1.MaxLength = 50;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.treeView1);
			this.Name = "Form1";
			this.Text = "Lab11.5";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.BindingSource form1BindingSource;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
	}
}

