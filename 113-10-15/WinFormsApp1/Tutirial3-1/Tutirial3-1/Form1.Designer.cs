namespace Tutirial3_1
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtweek = new TextBox();
            txtday = new TextBox();
            txtmonth = new TextBox();
            txtyear = new TextBox();
            lblshow = new Label();
            btnshow = new Button();
            btnclear = new Button();
            btnout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(23, 33);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(23, 115);
            label2.Name = "label2";
            label2.Size = new Size(82, 41);
            label2.TabIndex = 1;
            label2.Text = "日期";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(23, 193);
            label3.Name = "label3";
            label3.Size = new Size(82, 41);
            label3.TabIndex = 2;
            label3.Text = "月份";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 24F);
            label4.Location = new Point(23, 270);
            label4.Name = "label4";
            label4.Size = new Size(82, 41);
            label4.TabIndex = 3;
            label4.Text = "年份";
            // 
            // txtweek
            // 
            txtweek.Font = new Font("Microsoft JhengHei UI", 24F);
            txtweek.Location = new Point(219, 33);
            txtweek.Name = "txtweek";
            txtweek.Size = new Size(206, 48);
            txtweek.TabIndex = 4;
            // 
            // txtday
            // 
            txtday.Font = new Font("Microsoft JhengHei UI", 24F);
            txtday.Location = new Point(219, 112);
            txtday.Name = "txtday";
            txtday.Size = new Size(206, 48);
            txtday.TabIndex = 5;
            // 
            // txtmonth
            // 
            txtmonth.Font = new Font("Microsoft JhengHei UI", 24F);
            txtmonth.Location = new Point(219, 190);
            txtmonth.Name = "txtmonth";
            txtmonth.Size = new Size(206, 48);
            txtmonth.TabIndex = 6;
            // 
            // txtyear
            // 
            txtyear.Font = new Font("Microsoft JhengHei UI", 24F);
            txtyear.Location = new Point(219, 270);
            txtyear.Name = "txtyear";
            txtyear.Size = new Size(206, 48);
            txtyear.TabIndex = 7;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(219, 334);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(311, 47);
            lblshow.TabIndex = 8;
            // 
            // btnshow
            // 
            btnshow.Font = new Font("Microsoft JhengHei UI", 10F);
            btnshow.Location = new Point(62, 394);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(124, 44);
            btnshow.TabIndex = 9;
            btnshow.Text = "顯示完整日期";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft JhengHei UI", 10F);
            btnclear.Location = new Point(360, 394);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(124, 44);
            btnclear.TabIndex = 10;
            btnclear.Text = "清空內容";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnout
            // 
            btnout.Font = new Font("Microsoft JhengHei UI", 24F);
            btnout.Location = new Point(601, 394);
            btnout.Name = "btnout";
            btnout.Size = new Size(124, 44);
            btnout.TabIndex = 11;
            btnout.Text = "離開";
            btnout.UseVisualStyleBackColor = true;
            btnout.Click += btnout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnout);
            Controls.Add(btnclear);
            Controls.Add(btnshow);
            Controls.Add(lblshow);
            Controls.Add(txtyear);
            Controls.Add(txtmonth);
            Controls.Add(txtday);
            Controls.Add(txtweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtweek;
        private TextBox txtday;
        private TextBox txtmonth;
        private TextBox txtyear;
        private Label lblshow;
        private Button btnshow;
        private Button btnclear;
        private Button btnout;
    }
}
