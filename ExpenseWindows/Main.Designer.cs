namespace ExpenseWindows
{
    partial class MainForm
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAllRec = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExpOnly = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDisc = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.sslDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslBalance = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslNet = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslIncome = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslExpense = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTree = new System.Windows.Forms.Panel();
            this.tvByMonth = new System.Windows.Forms.TreeView();
            this.pnlChart = new System.Windows.Forms.Panel();
            this.pnlRec = new System.Windows.Forms.Panel();
            this.gvRecord = new System.Windows.Forms.DataGridView();
            this.msMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.pnlTree.SuspendLayout();
            this.pnlRec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiEdit,
            this.tsmiView,
            this.tsmiTools});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 28);
            this.msMain.TabIndex = 0;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew,
            this.tsmiOpen,
            this.tsmiSave,
            this.tsmiSaveAs,
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(46, 24);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(143, 26);
            this.tsmiNew.Text = "&New";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(143, 26);
            this.tsmiOpen.Text = "&Open";
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(143, 26);
            this.tsmiSave.Text = "&Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiSaveAs
            // 
            this.tsmiSaveAs.Name = "tsmiSaveAs";
            this.tsmiSaveAs.Size = new System.Drawing.Size(143, 26);
            this.tsmiSaveAs.Text = "Save &As";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(143, 26);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste,
            this.tsmiDelete});
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(49, 24);
            this.tsmiEdit.Text = "&Edit";
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(136, 26);
            this.tsmiAdd.Text = "&Add";
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(136, 26);
            this.tsmiCut.Text = "Cu&t";
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(136, 26);
            this.tsmiCopy.Text = "&Copy";
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(136, 26);
            this.tsmiPaste.Text = "&Paste";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(136, 26);
            this.tsmiDelete.Text = "&Delete";
            // 
            // tsmiView
            // 
            this.tsmiView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAllRec,
            this.tsmiInOnly,
            this.tsmiExpOnly});
            this.tsmiView.Name = "tsmiView";
            this.tsmiView.Size = new System.Drawing.Size(55, 24);
            this.tsmiView.Text = "&View";
            // 
            // tsmiAllRec
            // 
            this.tsmiAllRec.Name = "tsmiAllRec";
            this.tsmiAllRec.Size = new System.Drawing.Size(186, 26);
            this.tsmiAllRec.Text = "&All Records";
            // 
            // tsmiInOnly
            // 
            this.tsmiInOnly.Name = "tsmiInOnly";
            this.tsmiInOnly.Size = new System.Drawing.Size(186, 26);
            this.tsmiInOnly.Text = "&Income Only";
            // 
            // tsmiExpOnly
            // 
            this.tsmiExpOnly.Name = "tsmiExpOnly";
            this.tsmiExpOnly.Size = new System.Drawing.Size(186, 26);
            this.tsmiExpOnly.Text = "Expe&nses Only";
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTax,
            this.tsmiDisc});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(58, 24);
            this.tsmiTools.Text = "&Tools";
            // 
            // tsmiTax
            // 
            this.tsmiTax.Name = "tsmiTax";
            this.tsmiTax.Size = new System.Drawing.Size(209, 26);
            this.tsmiTax.Text = "Set &Tax Rate";
            // 
            // tsmiDisc
            // 
            this.tsmiDisc.Name = "tsmiDisc";
            this.tsmiDisc.Size = new System.Drawing.Size(209, 26);
            this.tsmiDisc.Text = "Set &Discount Rate";
            // 
            // ssMain
            // 
            this.ssMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslDate,
            this.sslMsg,
            this.sslBalance,
            this.sslNet,
            this.sslIncome,
            this.sslExpense});
            this.ssMain.Location = new System.Drawing.Point(0, 424);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(800, 26);
            this.ssMain.SizingGrip = false;
            this.ssMain.TabIndex = 1;
            // 
            // sslDate
            // 
            this.sslDate.Name = "sslDate";
            this.sslDate.Size = new System.Drawing.Size(41, 20);
            this.sslDate.Text = "Date";
            // 
            // sslMsg
            // 
            this.sslMsg.Name = "sslMsg";
            this.sslMsg.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.sslMsg.Size = new System.Drawing.Size(209, 20);
            this.sslMsg.Text = "Open a file or Create one.";
            // 
            // sslBalance
            // 
            this.sslBalance.Name = "sslBalance";
            this.sslBalance.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.sslBalance.Size = new System.Drawing.Size(355, 20);
            this.sslBalance.Spring = true;
            this.sslBalance.Text = "Balance";
            this.sslBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sslNet
            // 
            this.sslNet.Name = "sslNet";
            this.sslNet.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.sslNet.Size = new System.Drawing.Size(43, 20);
            this.sslNet.Text = "Net";
            // 
            // sslIncome
            // 
            this.sslIncome.Name = "sslIncome";
            this.sslIncome.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.sslIncome.Size = new System.Drawing.Size(68, 20);
            this.sslIncome.Text = "Income";
            // 
            // sslExpense
            // 
            this.sslExpense.Name = "sslExpense";
            this.sslExpense.Size = new System.Drawing.Size(69, 20);
            this.sslExpense.Text = "Expenses";
            // 
            // pnlTree
            // 
            this.pnlTree.Controls.Add(this.tvByMonth);
            this.pnlTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTree.Location = new System.Drawing.Point(0, 28);
            this.pnlTree.Name = "pnlTree";
            this.pnlTree.Padding = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.pnlTree.Size = new System.Drawing.Size(250, 396);
            this.pnlTree.TabIndex = 2;
            // 
            // tvByMonth
            // 
            this.tvByMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvByMonth.Location = new System.Drawing.Point(0, 0);
            this.tvByMonth.Name = "tvByMonth";
            this.tvByMonth.ShowLines = false;
            this.tvByMonth.ShowPlusMinus = false;
            this.tvByMonth.ShowRootLines = false;
            this.tvByMonth.Size = new System.Drawing.Size(247, 393);
            this.tvByMonth.TabIndex = 0;
            this.tvByMonth.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvByMonth_BeforeCollapse);
            this.tvByMonth.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvByMonth_AfterSelect);
            // 
            // pnlChart
            // 
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChart.Location = new System.Drawing.Point(250, 299);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pnlChart.Size = new System.Drawing.Size(550, 125);
            this.pnlChart.TabIndex = 3;
            // 
            // pnlRec
            // 
            this.pnlRec.Controls.Add(this.gvRecord);
            this.pnlRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRec.Location = new System.Drawing.Point(250, 28);
            this.pnlRec.Name = "pnlRec";
            this.pnlRec.Size = new System.Drawing.Size(550, 271);
            this.pnlRec.TabIndex = 4;
            // 
            // gvRecord
            // 
            this.gvRecord.AllowUserToAddRows = false;
            this.gvRecord.AllowUserToResizeRows = false;
            this.gvRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gvRecord.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvRecord.Location = new System.Drawing.Point(0, 0);
            this.gvRecord.Name = "gvRecord";
            this.gvRecord.ReadOnly = true;
            this.gvRecord.RowHeadersVisible = false;
            this.gvRecord.RowHeadersWidth = 51;
            this.gvRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvRecord.Size = new System.Drawing.Size(550, 271);
            this.gvRecord.TabIndex = 0;
            this.gvRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvRecord_CellDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlRec);
            this.Controls.Add(this.pnlChart);
            this.Controls.Add(this.pnlTree);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expense";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.pnlTree.ResumeLayout(false);
            this.pnlRec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TsmiExit_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.Panel pnlTree;
        private System.Windows.Forms.TreeView tvByMonth;
        private System.Windows.Forms.Panel pnlChart;
        private System.Windows.Forms.Panel pnlRec;
        private System.Windows.Forms.ToolStripStatusLabel sslDate;
        private System.Windows.Forms.ToolStripStatusLabel sslMsg;
        private System.Windows.Forms.ToolStripStatusLabel sslBalance;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiView;
        private System.Windows.Forms.ToolStripMenuItem tsmiAllRec;
        private System.Windows.Forms.ToolStripMenuItem tsmiInOnly;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpOnly;
        private System.Windows.Forms.ToolStripStatusLabel sslNet;
        private System.Windows.Forms.ToolStripStatusLabel sslIncome;
        private System.Windows.Forms.ToolStripStatusLabel sslExpense;
        private System.Windows.Forms.DataGridView gvRecord;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiTax;
        private System.Windows.Forms.ToolStripMenuItem tsmiDisc;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
    }
}

