using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpenseLib;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExpenseWindows
{
    public partial class MainForm : Form
    {
        internal List<string> inCat, expCat, units;
        public readonly Dictionary<string, string> monthString =
            new Dictionary<string, string> {
                { "a", "January" },
                { "b", "February" },
                { "c", "March" },
                { "d", "April" },
                { "e", "May" },
                { "f", "June" },
                { "g", "July" },
                { "h", "August" },
                { "i", "September" },
                { "j", "October" },
                { "k", "November" },
                { "l", "December" }
        };
        internal Dictionary<string, Dictionary<string, List<Record>>> rec;
        internal string path;
        internal bool refresh = false;

        private DataGridViewTextBoxColumn tbcType, tbcCat, tbcAmt, tbcDate, tbcMemo;

        public MainForm()
        {
            InitializeComponent();
            sslDate.Text = DateTime.Today.ToShortDateString();

            tbcAmt = new DataGridViewTextBoxColumn();
            tbcCat = new DataGridViewTextBoxColumn();
            tbcDate = new DataGridViewTextBoxColumn();
            tbcMemo = new DataGridViewTextBoxColumn();
            tbcType = new DataGridViewTextBoxColumn();
            gvRecord.Columns.AddRange(new DataGridViewColumn[] {
                tbcType,
                tbcCat,
                tbcAmt,
                tbcDate,
                tbcMemo
            });

            tbcType.HeaderText = "Type";
            tbcType.Name = "tbcType";

            tbcCat.HeaderText = "Category";
            tbcCat.Name = "tbcCat";

            tbcAmt.HeaderText = "Amount";
            tbcAmt.Name = "tbcAmt";

            tbcDate.HeaderText = "Date";
            tbcDate.Name = "tbcDate";

            tbcMemo.HeaderText = "Memo";
            tbcMemo.Name = "tbcMemo";

            if (File.Exists("path.ini"))
            {
                string conf = File.ReadAllText("path.ini");
                path = conf.Substring(5);
                if (conf.StartsWith("PATH=") && File.Exists(path))
                    FileOpened(JObject.Parse(File.ReadAllText(path)));
            }
        }

        private void FileOpened(JObject json)
        {
            Text = path + " - Expense";
            sslMsg.Text = "Ready.";

            File.WriteAllText("path.ini", "PATH=" + path);

            inCat = Data.ReadCategory(json, true);
            expCat = Data.ReadCategory(json, false);
            units = Data.ReadUnit(json);
            rec = Data.ReadRecords(json);

            tvByMonth.Nodes.Clear();

            foreach (string year in rec.Keys.OrderByDescending(i => i))
            {
                TreeNode ynode = new TreeNode();
                ynode.Name = ynode.Text = year;
                tvByMonth.Nodes.Add(ynode);
                ynode.Nodes.Clear();
                foreach (string month in rec[year].Keys.OrderByDescending(i => i))
                {
                    TreeNode mnode = new TreeNode(monthString[month]);
                    mnode.Name = month;
                    ynode.Nodes.Add(mnode);
                }
            }
            tvByMonth.ExpandAll();
        }

        private void tvByMonth_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }
        private void tvByMonth_AfterSelect(object sender, TreeViewEventArgs e)
        {
            RefreshGv();
        }
        private void RefreshGv()
        {
            gvRecord.Rows.Clear();
            TreeNode selected = tvByMonth.SelectedNode;
            rec[selected.Parent.Name][selected.Name] =
                (List<Record>)rec[selected.Parent.Name][selected.Name].OrderByDescending(i => i.Date);
            if (selected.Parent != null)
                foreach (Record r in rec[selected.Parent.Name][selected.Name])
                    gvRecord.Rows.Add(
                        r.Exp ? "Expense" : "Income",
                        r.Exp ? expCat[r.Category] : inCat[r.Category],
                        r.Amount.ToString("C2"),
                        r.Date.ToShortDateString(),
                        r.Memo
                    );
        }

        private enum RecOrderBy { }
        private void SortRec(List<Record> rs)
        {

        }

        private void gvRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreeNode selected = tvByMonth.SelectedNode;
            string year = selected.Parent.Name,
                month = selected.Name;
            new EntryForm(rec[year][month][e.RowIndex], true).ShowDialog();
            if (refresh) RefreshGv();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            File.WriteAllText(path, Data.WriteJson(inCat, expCat, rec));
            Text = path + " - Expense";
        }
    }
}
