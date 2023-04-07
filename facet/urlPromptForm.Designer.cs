namespace facet
{
    partial class urlPromptForm
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
            this.boxLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxLabel
            // 
            this.boxLabel.AutoSize = true;
            this.boxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxLabel.Location = new System.Drawing.Point(12, 11);
            this.boxLabel.Name = "boxLabel";
            this.boxLabel.Size = new System.Drawing.Size(88, 45);
            this.boxLabel.TabIndex = 1;
            this.boxLabel.Text = "label";
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(123, 22);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(665, 31);
            this.input.TabIndex = 2;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(676, 59);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(112, 34);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "button1";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // urlPromptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 104);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.input);
            this.Controls.Add(this.boxLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "urlPromptForm";
            this.Text = "urlPromptForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label boxLabel;
        private TextBox input;
        private Button confirmButton;
    }
}