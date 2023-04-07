using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facet
{
    public partial class urlPromptForm : Form
    {
        bool confirmed = false;
        public urlPromptForm()
        {
            InitializeComponent();
        }

        public void setVals(string labelText, string buttonText, string defaultInput = "")
        {
            boxLabel.Text = labelText;
            confirmButton.Text = buttonText;
            if (defaultInput != "") input.Text = defaultInput;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            confirmed = true;
            this.Close();
        }

        public string getResults()
        {
            if (confirmed) return input.Text;
            else return "xCANCELLEDx";
        }
    }
}
