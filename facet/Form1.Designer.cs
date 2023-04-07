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
            this.reloadDBRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.primaryFilter = new System.Windows.Forms.ListBox();
            this.secondaryFilter = new System.Windows.Forms.ListBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.listView = new System.Windows.Forms.ListView();
            this.comparisonList = new System.Windows.Forms.ListView();
            this.tertiaryFilter = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
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
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(2344, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDBRToolStripMenuItem,
            this.openDBRToolStripMenuItem,
            this.reloadDBRToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(42, 28);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // newDBRToolStripMenuItem
            // 
            this.newDBRToolStripMenuItem.Name = "newDBRToolStripMenuItem";
            this.newDBRToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.newDBRToolStripMenuItem.Text = "New DBR";
            // 
            // openDBRToolStripMenuItem
            // 
            this.openDBRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.openURLToolStripMenuItem});
            this.openDBRToolStripMenuItem.Name = "openDBRToolStripMenuItem";
            this.openDBRToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.openDBRToolStripMenuItem.Text = "Open DBR";
            this.openDBRToolStripMenuItem.Click += new System.EventHandler(this.openDBRToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openURLToolStripMenuItem
            // 
            this.openURLToolStripMenuItem.Name = "openURLToolStripMenuItem";
            this.openURLToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.openURLToolStripMenuItem.Text = "Open URL";
            this.openURLToolStripMenuItem.Click += new System.EventHandler(this.openURLToolStripMenuItem_Click);
            // 
            // reloadDBRToolStripMenuItem
            // 
            this.reloadDBRToolStripMenuItem.Name = "reloadDBRToolStripMenuItem";
            this.reloadDBRToolStripMenuItem.Size = new System.Drawing.Size(207, 34);
            this.reloadDBRToolStripMenuItem.Text = "Reload DBR";
            this.reloadDBRToolStripMenuItem.Click += new System.EventHandler(this.reloadDBRToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // primaryFilter
            // 
            this.primaryFilter.FormattingEnabled = true;
            this.primaryFilter.ItemHeight = 25;
            this.primaryFilter.Location = new System.Drawing.Point(11, 47);
            this.primaryFilter.Name = "primaryFilter";
            this.primaryFilter.Size = new System.Drawing.Size(204, 104);
            this.primaryFilter.TabIndex = 2;
            this.primaryFilter.SelectedIndexChanged += new System.EventHandler(this.primaryFilter_SelectedIndexChanged);
            // 
            // secondaryFilter
            // 
            this.secondaryFilter.FormattingEnabled = true;
            this.secondaryFilter.ItemHeight = 25;
            this.secondaryFilter.Location = new System.Drawing.Point(221, 47);
            this.secondaryFilter.Name = "secondaryFilter";
            this.secondaryFilter.Size = new System.Drawing.Size(210, 104);
            this.secondaryFilter.TabIndex = 3;
            this.secondaryFilter.SelectedIndexChanged += new System.EventHandler(this.secondaryFilter_SelectedIndexChanged);
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(11, 157);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(420, 956);
            this.tree.TabIndex = 4;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Location = new System.Drawing.Point(439, 47);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(997, 1024);
            this.listView.TabIndex = 5;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // comparisonList
            // 
            this.comparisonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comparisonList.Location = new System.Drawing.Point(1443, 157);
            this.comparisonList.Name = "comparisonList";
            this.comparisonList.Size = new System.Drawing.Size(890, 956);
            this.comparisonList.TabIndex = 5;
            this.comparisonList.UseCompatibleStateImageBehavior = false;
            this.comparisonList.View = System.Windows.Forms.View.Details;
            // 
            // tertiaryFilter
            // 
            this.tertiaryFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tertiaryFilter.FormattingEnabled = true;
            this.tertiaryFilter.ItemHeight = 25;
            this.tertiaryFilter.Location = new System.Drawing.Point(1443, 47);
            this.tertiaryFilter.Name = "tertiaryFilter";
            this.tertiaryFilter.Size = new System.Drawing.Size(890, 104);
            this.tertiaryFilter.TabIndex = 6;
            this.tertiaryFilter.SelectedIndexChanged += new System.EventHandler(this.tertiaryFilter_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(437, 1077);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 34);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add Entry";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Enabled = false;
            this.editButton.Location = new System.Drawing.Point(555, 1077);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 34);
            this.editButton.TabIndex = 8;
            this.editButton.Text = "Edit Entry";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // delButton
            // 
            this.delButton.Enabled = false;
            this.delButton.Location = new System.Drawing.Point(1325, 1077);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(112, 34);
            this.delButton.TabIndex = 9;
            this.delButton.Text = "Del Entry";
            this.delButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(673, 1077);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(228, 34);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Database";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2344, 1125);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.tertiaryFilter);
            this.Controls.Add(this.comparisonList);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.secondaryFilter);
            this.Controls.Add(this.primaryFilter);
            this.Controls.Add(this.toolStrip1);
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
        private Button addButton;
        private Button editButton;
        private Button delButton;
        private Button saveButton;
        private ToolStripMenuItem reloadDBRToolStripMenuItem;
    }
}