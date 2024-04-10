namespace 記帳1
{
    partial class 記一筆
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Money = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Paymethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IncomeExpense = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Detail = new System.Windows.Forms.ComboBox();
            this.navbar1 = new 記帳1.Navbar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "類型";
            // 
            // item
            // 
            this.item.FormattingEnabled = true;
            this.item.Location = new System.Drawing.Point(77, 96);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(164, 20);
            this.item.TabIndex = 4;
            this.item.SelectedIndexChanged += new System.EventHandler(this.item_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "記帳";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 161);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(151, 330);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 161);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "收據/圖片";
            // 
            // Money
            // 
            this.Money.Location = new System.Drawing.Point(77, 219);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(164, 22);
            this.Money.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "支付方式";
            // 
            // Paymethod
            // 
            this.Paymethod.FormattingEnabled = true;
            this.Paymethod.Location = new System.Drawing.Point(77, 175);
            this.Paymethod.Name = "Paymethod";
            this.Paymethod.Size = new System.Drawing.Size(164, 20);
            this.Paymethod.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "收入/支出";
            // 
            // IncomeExpense
            // 
            this.IncomeExpense.FormattingEnabled = true;
            this.IncomeExpense.Location = new System.Drawing.Point(77, 55);
            this.IncomeExpense.Name = "IncomeExpense";
            this.IncomeExpense.Size = new System.Drawing.Size(164, 20);
            this.IncomeExpense.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "細項";
            // 
            // Detail
            // 
            this.Detail.FormattingEnabled = true;
            this.Detail.Location = new System.Drawing.Point(77, 134);
            this.Detail.Name = "Detail";
            this.Detail.Size = new System.Drawing.Size(164, 20);
            this.Detail.TabIndex = 15;
            // 
            // navbar1
            // 
            this.navbar1.Location = new System.Drawing.Point(2, 519);
            this.navbar1.Name = "navbar1";
            this.navbar1.Size = new System.Drawing.Size(291, 42);
            this.navbar1.TabIndex = 0;
            this.navbar1.Load += new System.EventHandler(this.navbar1_Load);
            // 
            // 記一筆
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 561);
            this.Controls.Add(this.Detail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.IncomeExpense);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Paymethod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.item);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.navbar1);
            this.Name = "記一筆";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "記一筆";
            this.Load += new System.EventHandler(this.記一筆_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navbar navbar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox item;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Money;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Paymethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox IncomeExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Detail;
    }
}