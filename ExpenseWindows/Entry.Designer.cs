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
            this.txtAmt = new System.Windows.Forms.TextBox();
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDisct = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnTax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radExpenses
            // 
            this.radExpenses.AutoSize = true;
            this.radExpenses.Checked = true;
            this.radExpenses.Location = new System.Drawing.Point(118, 23);
            this.radExpenses.Name = "radExpenses";
            this.radExpenses.Size = new System.Drawing.Size(90, 24);
            this.radExpenses.TabIndex = 0;
            this.radExpenses.TabStop = true;
            this.radExpenses.Text = "&Expenses";
            this.radExpenses.UseVisualStyleBackColor = true;
            // 
            // radIncome
            // 
            this.radIncome.AutoSize = true;
            this.radIncome.Location = new System.Drawing.Point(209, 23);
            this.radIncome.Name = "radIncome";
            this.radIncome.Size = new System.Drawing.Size(79, 24);
            this.radIncome.TabIndex = 0;
            this.radIncome.Text = "&Income";
            this.radIncome.UseVisualStyleBackColor = true;
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(395, 23);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(170, 28);
            this.cboCat.TabIndex = 1;
            // 
            // txtAmt
            // 
            this.txtAmt.Location = new System.Drawing.Point(118, 60);
            this.txtAmt.Name = "txtAmt";
            this.txtAmt.ReadOnly = true;
            this.txtAmt.Size = new System.Drawing.Size(170, 27);
            this.txtAmt.TabIndex = 2;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 148);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Location = new System.Drawing.Point(195, 114);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 31);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Del";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(131, 114);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(58, 31);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.AutoSize = true;
            this.btn0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn0.Location = new System.Drawing.Point(67, 114);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(58, 31);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.AutoSize = true;
            this.btnDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDot.Location = new System.Drawing.Point(3, 114);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(58, 31);
            this.btnDot.TabIndex = 0;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            this.btnEqual.AutoSize = true;
            this.btnEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEqual.Location = new System.Drawing.Point(195, 77);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(58, 31);
            this.btnEqual.TabIndex = 0;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(131, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(58, 31);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(67, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(58, 31);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(3, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(58, 31);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.AutoSize = true;
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMinus.Location = new System.Drawing.Point(195, 40);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(58, 31);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.AutoSize = true;
            this.btn6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn6.Location = new System.Drawing.Point(131, 40);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(58, 31);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.AutoSize = true;
            this.btn5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn5.Location = new System.Drawing.Point(67, 40);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(58, 31);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.AutoSize = true;
            this.btn4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn4.Location = new System.Drawing.Point(3, 40);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(58, 31);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.AutoSize = true;
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlus.Location = new System.Drawing.Point(195, 3);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(58, 31);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.AutoSize = true;
            this.btn9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn9.Location = new System.Drawing.Point(131, 3);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(58, 31);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.AutoSize = true;
            this.btn8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn8.Location = new System.Drawing.Point(67, 3);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(58, 31);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.AutoSize = true;
            this.btn7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn7.Location = new System.Drawing.Point(3, 3);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(58, 31);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(395, 114);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(170, 27);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Memo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(170, 27);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btnDisct
            // 
            this.btnDisct.Location = new System.Drawing.Point(456, 205);
            this.btnDisct.Name = "btnDisct";
            this.btnDisct.Size = new System.Drawing.Size(109, 43);
            this.btnDisct.TabIndex = 11;
            this.btnDisct.Text = "&Discount";
            this.btnDisct.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(479, 270);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(86, 38);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnTax
            // 
            this.btnTax.Location = new System.Drawing.Point(312, 206);
            this.btnTax.Name = "btnTax";
            this.btnTax.Size = new System.Drawing.Size(109, 43);
            this.btnTax.TabIndex = 13;
            this.btnTax.Text = "&Tax";
            this.btnTax.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(395, 160);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 27);
            this.txtQty.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Unit:";
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(510, 159);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(55, 28);
            this.cboUnit.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(368, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // EntryForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(596, 331);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboUnit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTax);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnDisct);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtAmt);
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
            this.Text = "Entry";
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
        private System.Windows.Forms.TextBox txtAmt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnDisct;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Button btnCancel;
    }
}