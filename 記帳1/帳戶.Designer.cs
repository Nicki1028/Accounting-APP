namespace 記帳1
{
    partial class 帳戶
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
            this.navbar1 = new 記帳1.Navbar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.IncomeExpense = new System.Windows.Forms.ComboBox();
            this.Item = new System.Windows.Forms.ComboBox();
            this.Paymethod = new System.Windows.Forms.ComboBox();
            this.InEx = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.Payment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(1, 517);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(291, 42);
            this.navbar1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(69, 77);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "起始日";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "截止日";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 294);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(268, 201);
            this.flowLayoutPanel1.TabIndex = 7;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // IncomeExpense
            // 
            this.IncomeExpense.FormattingEnabled = true;
            this.IncomeExpense.Location = new System.Drawing.Point(84, 122);
            this.IncomeExpense.Name = "IncomeExpense";
            this.IncomeExpense.Size = new System.Drawing.Size(121, 20);
            this.IncomeExpense.TabIndex = 8;
            // 
            // Item
            // 
            this.Item.FormattingEnabled = true;
            this.Item.Location = new System.Drawing.Point(84, 163);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(121, 20);
            this.Item.TabIndex = 9;
            // 
            // Paymethod
            // 
            this.Paymethod.FormattingEnabled = true;
            this.Paymethod.Location = new System.Drawing.Point(84, 207);
            this.Paymethod.Name = "Paymethod";
            this.Paymethod.Size = new System.Drawing.Size(121, 20);
            this.Paymethod.TabIndex = 10;
            // 
            // InEx
            // 
            this.InEx.AutoSize = true;
            this.InEx.Location = new System.Drawing.Point(22, 125);
            this.InEx.Name = "InEx";
            this.InEx.Size = new System.Drawing.Size(56, 12);
            this.InEx.TabIndex = 11;
            this.InEx.Text = "收入/支出";
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Location = new System.Drawing.Point(22, 166);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(29, 12);
            this.ItemLabel.TabIndex = 12;
            this.ItemLabel.Text = "類別";
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Location = new System.Drawing.Point(22, 210);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(53, 12);
            this.Payment.TabIndex = 13;
            this.Payment.Text = "支付方式";
            // 
            // 帳戶
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 561);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.InEx);
            this.Controls.Add(this.Paymethod);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.IncomeExpense);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.navbar1);
            this.Name = "帳戶";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "帳戶";
            this.Load += new System.EventHandler(this.帳戶_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navbar navbar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox IncomeExpense;
        private System.Windows.Forms.ComboBox Item;
        private System.Windows.Forms.ComboBox Paymethod;
        private System.Windows.Forms.Label InEx;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label Payment;
    }
}