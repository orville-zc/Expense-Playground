namespace ExpenseWindows
{
    partial class EntryForm
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
            this.radExpenses = new System.Windows.Forms.RadioButton();
            this.radIncome = new System.Windows.Forms.RadioButton();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpRec = new System.Windows.Forms.DateTimePicker();
            this.btnDisct = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radExpenses
            // 
            this.radExpenses.AutoSize = true;
            this.radExpenses.Checked = true;
            this.radExpenses.Location = new System.Drawing.Point(396, 32);
            this.radExpenses.Name = "radExpenses";
            this.radExpenses.Size = new System.Drawing.Size(90, 24);
            this.radExpenses.TabIndex = 0;
            this.radExpenses.TabStop = true;
            this.radExpenses.Text = "&Expenses";
            this.radExpenses.UseVisualStyleBackColor = true;
            this.radExpenses.CheckedChanged += new System.EventHandler(this.radExpenses_CheckedChanged);
            this.radExpenses.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // radIncome
            // 
            this.radIncome.AutoSize = true;
            this.radIncome.Location = new System.Drawing.Point(487, 32);
            this.radIncome.Name = "radIncome";
            this.radIncome.Size = new System.Drawing.Size(79, 24);
            this.radIncome.TabIndex = 0;
            this.radIncome.TabStop = true;
            this.radIncome.Text = "&Income";
            this.radIncome.UseVisualStyleBackColor = true;
            this.radIncome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // cboCat
            // 
            this.cboCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(396, 75);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(170, 28);
            this.cboCat.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEqual, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMinus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPlus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 167);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(195, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 38);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(131, 126);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "&C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(67, 126);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 38);
            this.btn0.TabIndex = 2;
            this.btn0.TabStop = false;
            this.btn0.Text = "&0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btnN_Click);
            this.btn0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Location = new System.Drawing.Point(3, 126);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(58, 38);
            this.btnDot.TabIndex = 3;
            this.btnDot.TabStop = false;
            this.btnDot.Text = "&.";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            this.btnDot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(195, 85);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(58, 35);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.TabStop = false;
            this.btnEqual.Text = "&=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btnEqual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(131, 85);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 35);
            this.btn3.TabIndex = 5;
            this.btn3.TabStop = false;
            this.btn3.Text = "&3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnN_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(67, 85);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 35);
            this.btn2.TabIndex = 6;
            this.btn2.TabStop = false;
            this.btn2.Text = "&2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnN_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 85);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 35);
            this.btn1.TabIndex = 7;
            this.btn1.TabStop = false;
            this.btn1.Text = "&1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnN_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(195, 44);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(58, 35);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.TabStop = false;
            this.btnMinus.Text = "&-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            this.btnMinus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(131, 44);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 35);
            this.btn6.TabIndex = 9;
            this.btn6.TabStop = false;
            this.btn6.Text = "&6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnN_Click);
            this.btn6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(67, 44);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 35);
            this.btn5.TabIndex = 10;
            this.btn5.TabStop = false;
            this.btn5.Text = "&5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnN_Click);
            this.btn5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 44);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 35);
            this.btn4.TabIndex = 11;
            this.btn4.TabStop = false;
            this.btn4.Text = "&4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnN_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(195, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(58, 35);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.TabStop = false;
            this.btnPlus.Text = "&+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnOperator_Click);
            this.btnPlus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(131, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 35);
            this.btn9.TabIndex = 13;
            this.btn9.TabStop = false;
            this.btn9.Text = "&9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnN_Click);
            this.btn9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(67, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 35);
            this.btn8.TabIndex = 14;
            this.btn8.TabStop = false;
            this.btn8.Text = "&8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnN_Click);
            this.btn8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 35);
            this.btn7.TabIndex = 15;
            this.btn7.TabStop = false;
            this.btn7.Text = "&7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnN_Click);
            this.btn7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(396, 167);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(170, 27);
            this.txtMemo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Memo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            // 
            // dtpRec
            // 
            this.dtpRec.Location = new System.Drawing.Point(396, 119);
            this.dtpRec.Name = "dtpRec";
            this.dtpRec.Size = new System.Drawing.Size(170, 27);
            this.dtpRec.TabIndex = 2;
            // 
            // btnDisct
            // 
            this.btnDisct.Location = new System.Drawing.Point(174, 261);
            this.btnDisct.Name = "btnDisct";
            this.btnDisct.Size = new System.Drawing.Size(109, 38);
            this.btnDisct.TabIndex = 9;
            this.btnDisct.TabStop = false;
            this.btnDisct.Text = "&Discount";
            this.btnDisct.UseVisualStyleBackColor = true;
            this.btnDisct.Click += new System.EventHandler(this.btnDisct_Click);
            this.btnDisct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(480, 260);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 38);
            this.btnOk.TabIndex = 8;
            this.btnOk.TabStop = false;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(33, 260);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(109, 38);
            this.btnTax.TabIndex = 7;
            this.btnTax.TabStop = false;
            this.btnTax.Text = "&Tax";
            this.btnTax.UseVisualStyleBackColor = true;
            this.btnTax.Click += new System.EventHandler(this.btnTax_Click);
            this.btnTax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ForAmount_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Unit:";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Items.AddRange(new object[] {
            "N/A"});
            this.cboUnit.Location = new System.Drawing.Point(511, 214);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(55, 28);
            this.cboUnit.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(369, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 38);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(396, 215);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 27);
            this.txtQty.TabIndex = 4;
            // 
            // lblAmt
            // 
            this.lblAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmt.Location = new System.Drawing.Point(113, 31);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(170, 27);
            this.lblAmt.TabIndex = 0;
            this.lblAmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(596, 331);
            this.Controls.Add(this.lblAmt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDisct);
            this.Controls.Add(this.dtpRec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.radIncome);
            this.Controls.Add(this.radExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " an Entry";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radExpenses;
        private System.Windows.Forms.RadioButton radIncome;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpRec;
        private System.Windows.Forms.Button btnDisct;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblAmt;
    }
}