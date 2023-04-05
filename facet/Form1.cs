using System.ComponentModel.DataAnnotations;
using System.Text;

namespace facet
{
    public partial class Form1 : Form
    {
        string dbrPath = "";
        Database db;

        public Form1()
        {
            InitializeComponent();
        }

        private void openDBRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void primaryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            tertiaryFilter.Items.Clear();
            comparisonList.Items.Clear();
            updatePrimaryFilter();
            secondaryFilter.Items.Clear();
            listView.Items.Clear();
            for (int i = 0; i < primaryFilter.Items.Count;i++)
            {
                if (i != primaryFilter.SelectedIndex) secondaryFilter.Items.Add(primaryFilter.Items[i]);
            }
        }

        private void secondaryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

            tertiaryFilter.Items.Clear();
            comparisonList.Items.Clear();
            updateSecondaryFilter();
            listView.Items.Clear();
        }

        public void updatePrimaryFilter()
        {
            int filterIndex = getFilterIndex();
            
            List<string> categories = new List<string>();
            List<string> lowerCaseCategories = new List<string>();
            List<PseudoRow> pseudoRows = new List<PseudoRow>();
            foreach (Row r in db.Rows)
            {
                if (r.index != 0 && !lowerCaseCategories.Contains(r.Values[filterIndex].stringValue.ToLower())) { categories.Add(r.Values[filterIndex].stringValue); lowerCaseCategories.Add(r.Values[filterIndex].stringValue.ToLower()); pseudoRows.Add(new PseudoRow()); }
            }
            tree.Nodes.Clear();
            categories.Sort();
            foreach (string category in categories) tree.Nodes.Add(category);
        }

        public void updateSecondaryFilter()
        {
            int primaryFilterIndex = getFilterIndex();
            int secondaryFilterIndex = getFilterIndex(1);

            foreach (TreeNode node in tree.Nodes)
            {
                List<string> categories = new List<string>();
                List<string> lowerCaseCategories = new List<string>();
                foreach (Row r in db.Rows)
                {
                    if (r.index != 0 && node.Text.ToLower() == r.Values[primaryFilterIndex].stringValue.ToLower() && !lowerCaseCategories.Contains(r.Values[secondaryFilterIndex].stringValue.ToLower())) { categories.Add(r.Values[secondaryFilterIndex].stringValue); lowerCaseCategories.Add(r.Values[secondaryFilterIndex].stringValue.ToLower()); }
                }
                node.Nodes.Clear();
                categories.Sort();
                foreach (string category in categories) node.Nodes.Add(category);
            }

        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tertiaryFilter.Items.Clear();
            comparisonList.Items.Clear();
            updateListView();
        }

        public void updateListView()
        {
            listView.Items.Clear();
            int primaryFilterIndex = getFilterIndex();
            int secondaryFilterIndex = getFilterIndex(1);

            if (secondaryFilterIndex == -1 || tree.SelectedNode.Nodes.Count != 0)
            {
                foreach (Row r in db.Rows)
                {
                    if (r.Values[primaryFilterIndex].stringValue.ToLower() == tree.SelectedNode.Text.ToLower())
                    {
                        string[] vals = new string[r.Values.Length];
                        for (int i = 0; i < vals.Length; i++) { vals[i] = r.Values[i].stringValue; }
                        var listViewItem = new ListViewItem(vals);
                        listView.Items.Add(listViewItem);
                    }
                }
            }
            else
            {
                List<Row> firstPass = new List<Row>();
                foreach (Row r in db.Rows)
                {
                    if (r.Values[primaryFilterIndex].stringValue.ToLower() == tree.SelectedNode.Parent.Text.ToLower())
                    {
                        string[] vals = new string[r.Values.Length];
                        for (int i = 0; i < vals.Length; i++) { vals[i] = r.Values[i].stringValue; }
                        firstPass.Add(r);
                    }
                }
                foreach (Row r in firstPass)
                {
                    if (r.Values[secondaryFilterIndex].stringValue.ToLower() == tree.SelectedNode.Text.ToLower())
                    {
                        string[] vals = new string[r.Values.Length];
                        for (int i = 0; i < vals.Length; i++) { vals[i] = r.Values[i].stringValue; }
                        var listViewItem = new ListViewItem(vals);
                        listView.Items.Add(listViewItem);
                    }
                }
            }
        }

        public int getFilterIndex(int filter = 0)
        {
            if (filter == 0)
            {
                for (int i = 0; i < db.columns.Length; i++)
                {
                    if (db.columns[i].stringValue == (string)primaryFilter.Items[primaryFilter.SelectedIndex]) { return i; }
                }
                return -1;
            }
            else if (filter == 1)
            {
                try
                {
                    for (int i = 0; i < db.columns.Length; i++)
                    {
                        if (db.columns[i].stringValue == (string)secondaryFilter.Items[secondaryFilter.SelectedIndex]) { return i; }
                    }
                }
                catch { }
                return -1;
            }
            else if (filter == 2)
            {
                for (int i = 0; i < db.columns.Length; i++)
                {
                    if (db.columns[i].stringValue == (string)tertiaryFilter.Items[tertiaryFilter.SelectedIndex]) { return i; }
                }
                return -1;
            }
            else return -1;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            dbrPath = openFileDialog1.FileName;
            db = new Database(File.ReadAllBytes(dbrPath));

            primaryFilter.Items.Clear();
            listView.Columns.Clear();
            comparisonList.Columns.Clear();
            foreach (Value v in db.Rows[0].Values)
            {
                primaryFilter.Items.Add(v.stringValue);
                listView.Columns.Add(v.stringValue);
                listView.Columns[listView.Columns.Count - 1].Width = 1000 / db.columns.Length;
                comparisonList.Columns.Add(v.stringValue);
                comparisonList.Columns[comparisonList.Columns.Count - 1].Width = 1000 / db.columns.Length;
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            tertiaryFilter.Items.Clear();
            comparisonList.Items.Clear();
            foreach (string item in primaryFilter.Items) tertiaryFilter.Items.Add(item);
        }

        private void tertiaryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            doCompare();
        }

        public void doCompare()
        {
            int filter = getFilterIndex(2);
            comparisonList.Items.Clear();
            foreach (Row r in db.Rows)
            {
                if (r.Values[filter].stringValue.ToLower() == listView.SelectedItems[0].SubItems[filter].Text.ToLower())
                {
                    string[] vals = new string[r.Values.Length];
                    for (int i = 0; i < vals.Length; i++) { vals[i] = r.Values[i].stringValue; }
                    var listViewItem = new ListViewItem(vals);
                    comparisonList.Items.Add(listViewItem);
                }
            }
        }
    }

    struct asciiCoder
    {
        public static string GetString(byte[] data)
        {
            char[] chars = new char[data.Length];
            string output = "";
            for (int i = 0; i < chars.Length; i++) chars[i] = Convert.ToChar(data[i]);
            foreach (char c in chars) if (Convert.ToInt16(c) != 0) output += c;
            return output;
        }
    }

    struct Database
    {
        public Row[] Rows = { };
        public Value[] columns = { };


        public Database(byte[] data)
        {
            int colCount = (int)data[2];
            int colSize = (int)data[0];
            Rows = new Row[data.Length / (colCount * colSize)];
            int rNum = 0;
            for (int i = 4; i < data.Length; i+= colCount*colSize)
            {
                byte[] RowData = new byte[colCount*colSize];

                for (int x = 0; x < colCount*colSize; x++)
                {
                    RowData[x] = data[i+x];
                }
                Row r = new Row(RowData, colSize, rNum);
                if (i == 4) columns = r.Values;
                Rows[rNum] = r;
                rNum++;
            }

        }
    }



    struct PseudoRow
    {
        public Value[] Values = { };
        public PseudoRow()
        {
        }

        public Row convertToRow()
        {
            return new Row();
        }

        public void addValue(byte[] valueData)
        {
            Value v = new Value(valueData);
            Value[] oldValues = Values;
            Values = new Value[Values.Length + 1];
            for (int i = 0; i < oldValues.Length; i++) Values[i] = oldValues[i];
            oldValues[oldValues.Length - 1] = v;
        }
    }

    struct Row
    {
        public Value[] Values = { };
        public int index;
        public Row(byte[] data, int colSize, int rowIndex = 0)
        {
            index = rowIndex;
            Values = new Value[data.Length / colSize];
            int vNum = 0;
            for (int i = 0; i < data.Length; i += colSize)
            {
                byte[] valData = new byte[colSize];
                for (int x = 0; x < colSize; x++)
                {
                    valData[x] = data[i + x];
                }
                Value v = new Value(valData);
                Values[vNum] = v;
                vNum++;
            }
        }
    }

    struct Value
    {
        public byte[] byteValue = { };
        public string stringValue = "";
        public Value(byte[] data)
        {
            byteValue = data;
            stringValue = asciiCoder.GetString(byteValue);
        }
    }
}