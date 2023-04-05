namespace facet
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.newDBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.primaryFilter = new System.Windows.Forms.ListBox();
            this.secondaryFilter = new System.Windows.Forms.ListBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.comparisonList = new System.Windows.Forms.ListView();
            this.tertiaryFilter = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1641, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDBRToolStripMenuItem,
            this.openDBRToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(37, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // newDBRToolStripMenuItem
            // 
            this.newDBRToolStripMenuItem.Name = "newDBRToolStripMenuItem";
            this.newDBRToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.newDBRToolStripMenuItem.Text = "New DBR";
            // 
            // openDBRToolStripMenuItem
            // 
            this.openDBRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openURLToolStripMenuItem});
            this.openDBRToolStripMenuItem.Name = "openDBRToolStripMenuItem";
            this.openDBRToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.openDBRToolStripMenuItem.Text = "Open DBR";
            this.openDBRToolStripMenuItem.Click += new System.EventHandler(this.openDBRToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openURLToolStripMenuItem
            // 
            this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
            this.openURLToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.openURLToolStripMenuItem.Text = "Open URL";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // primaryFilter
            // 
            this.primaryFilter.FormattingEnabled = true;
            this.primaryFilter.ItemHeight = 15;
            this.primaryFilter.Location = new System.Drawing.Point(8, 28);
            this.primaryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.primaryFilter.Name = "primaryFilter";
            this.primaryFilter.Size = new System.Drawing.Size(144, 64);
            this.primaryFilter.TabIndex = 2;
            this.primaryFilter.SelectedIndexChanged += new System.EventHandler(this.primaryFilter_SelectedIndexChanged);
            // 
            // secondaryFilter
            // 
            this.secondaryFilter.FormattingEnabled = true;
            this.secondaryFilter.ItemHeight = 15;
            this.secondaryFilter.Location = new System.Drawing.Point(155, 28);
            this.secondaryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.secondaryFilter.Name = "secondaryFilter";
            this.secondaryFilter.Size = new System.Drawing.Size(148, 64);
            this.secondaryFilter.TabIndex = 3;
            this.secondaryFilter.SelectedIndexChanged += new System.EventHandler(this.secondaryFilter_SelectedIndexChanged);
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(8, 94);
            this.tree.Margin = new System.Windows.Forms.Padding(2);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(295, 575);
            this.tree.TabIndex = 4;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Location = new System.Drawing.Point(307, 28);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(699, 641);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // comparisonList
            // 
            this.comparisonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comparisonList.Location = new System.Drawing.Point(1010, 94);
            this.comparisonList.Margin = new System.Windows.Forms.Padding(2);
            this.comparisonList.Name = "comparisonList";
            this.comparisonList.Size = new System.Drawing.Size(624, 575);
            this.comparisonList.TabIndex = 5;
            this.comparisonList.UseCompatibleStateImageBehavior = false;
            this.comparisonList.View = System.Windows.Forms.View.Details;
            // 
            // tertiaryFilter
            // 
            this.tertiaryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tertiaryFilter.FormattingEnabled = true;
            this.tertiaryFilter.ItemHeight = 15;
            this.tertiaryFilter.Location = new System.Drawing.Point(1010, 28);
            this.tertiaryFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tertiaryFilter.Name = "tertiaryFilter";
            this.tertiaryFilter.Size = new System.Drawing.Size(624, 64);
            this.tertiaryFilter.TabIndex = 6;
            this.tertiaryFilter.SelectedIndexChanged += new System.EventHandler(this.tertiaryFilter_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 675);
            this.Controls.Add(this.tertiaryFilter);
            this.Controls.Add(this.comparisonList);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.secondaryFilter);
            this.Controls.Add(this.primaryFilter);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Facet";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem newDBRToolStripMenuItem;
        private ToolStripMenuItem openDBRToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private ListBox primaryFilter;
        private ListBox secondaryFilter;
        private TreeView tree;
        private ListView listView;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem openURLToolStripMenuItem;
        private ListView comparisonList;
        private ListBox tertiaryFilter;
    }
}