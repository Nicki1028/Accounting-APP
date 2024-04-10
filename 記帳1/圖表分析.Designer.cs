namespace 記帳1
{
    partial class 圖表分析
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
            this.Payment = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.InEx = new System.Windows.Forms.Label();
            this.Paymethod = new System.Windows.Forms.ComboBox();
            this.Item = new System.Windows.Forms.ComboBox();
            this.IncomeExpense = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ChartType = new System.Windows.Forms.ComboBox();
            this.navbar1 = new 記帳1.Navbar();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(27, 177);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(53, 12);
            this.Payment.TabIndex = 25;
            this.Payment.Text = "支付方式";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(27, 133);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(29, 12);
            this.ItemLabel.TabIndex = 24;
            this.ItemLabel.Text = "類別";
            // 
            // InEx
            // 
            this.InEx.AutoSize = true;
            this.InEx.Location = new System.Drawing.Point(27, 92);
            this.InEx.Name = "InEx";
            this.InEx.Size = new System.Drawing.Size(56, 12);
            this.InEx.TabIndex = 23;
            this.InEx.Text = "收入/支出";
            // 
            // Paymethod
            // 
            this.Paymethod.FormattingEnabled = true;
            this.Paymethod.Location = new System.Drawing.Point(89, 174);
            this.Paymethod.Name = "Paymethod";
            this.Paymethod.Size = new System.Drawing.Size(121, 20);
            this.Paymethod.TabIndex = 22;
            // 
            // Item
            // 
            this.Item.FormattingEnabled = true;
            this.Item.Location = new System.Drawing.Point(89, 130);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(121, 20);
            this.Item.TabIndex = 21;
            // 
            // IncomeExpense
            // 
            this.IncomeExpense.FormattingEnabled = true;
            this.IncomeExpense.Location = new System.Drawing.Point(89, 89);
            this.IncomeExpense.Name = "IncomeExpense";
            this.IncomeExpense.Size = new System.Drawing.Size(121, 20);
            this.IncomeExpense.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "查詢";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 17;
            this.label2.Text = "截止日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 16;
            this.label1.Text = "起始日";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(74, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 238);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(279, 273);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // ChartType
            // 
            this.ChartType.FormattingEnabled = true;
            this.ChartType.Location = new System.Drawing.Point(29, 209);
            this.ChartType.Name = "ChartType";
            this.ChartType.Size = new System.Drawing.Size(121, 20);
            this.ChartType.TabIndex = 27;
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(0, 517);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(291, 42);
            this.navbar1.TabIndex = 0;
            // 
            // 圖表分析
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 561);
            this.Controls.Add(this.ChartType);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.InEx);
            this.Controls.Add(this.Paymethod);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.IncomeExpense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.navbar1);
            this.Name = "圖表分析";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "圖表分析";
            this.Load += new System.EventHandler(this.圖表分析_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navbar navbar1;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label InEx;
        private System.Windows.Forms.ComboBox Paymethod;
        private System.Windows.Forms.ComboBox Item;
        private System.Windows.Forms.ComboBox IncomeExpense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox ChartType;
    }
}