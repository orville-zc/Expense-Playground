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
    public partial class frmMain : Form
    {
        internal Dictionary<int, string> inCat, expCat,
            monthString = new Dictionary<int, string> {
                { 0, "January" },
                { 1, "February" },
                { 2, "March" },
                { 3, "April" },
                { 4, "May" },
                { 5, "June" },
                { 6, "July" },
                { 7, "August" },
                { 8, "September" },
                { 9, "October" },
                { 10, "November" },
                { 11, "December " }
            };
        internal Dictionary<int, Dictionary<int, List<Record>>> rec;
        internal string path;
        public frmMain()
        {
            InitializeComponent();
            sslDate.Text = DateTime.Today.ToShortDateString();
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
            sslMsg.Text = "Ready.";
            File.WriteAllText("path.ini", "PATH=" + path);
            inCat = Data.ReadCategory(json, true);
            expCat = Data.ReadCategory(json, false);
            rec = Data.ReadRecords(json);
            tvByMonth.Nodes.Clear();
            foreach (var year in rec.Keys)
            {
                TreeNode ynode = new TreeNode();
                ynode.Name = ynode.Text = year.ToString();
                tvByMonth.Nodes.Add(ynode);
                ynode.Nodes.Clear();
                foreach (var month in rec[year].Keys)
                {
                    TreeNode mnode = new TreeNode(monthString[month]);
                    mnode.Name = month.ToString();
                    ynode.Nodes.Add(mnode);
                }
            }
            tvByMonth.ExpandAll();
        }

        private void tvByMonth_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
