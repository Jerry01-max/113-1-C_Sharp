﻿namespace WinFormsApp2
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
            txtkm = new TextBox();
            txyliter = new TextBox();
            lblshow = new Label();
            btncalculate = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(46, 55);
            label1.Name = "label1";
            label1.Size = new Size(114, 41);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(46, 127);
            label2.Name = "label2";
            label2.Size = new Size(146, 41);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(46, 215);
            label3.Name = "label3";
            label3.Size = new Size(191, 41);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            // 
            // txtkm
            // 
            txtkm.Font = new Font("Microsoft JhengHei UI", 24F);
            txtkm.Location = new Point(351, 55);
            txtkm.Name = "txtkm";
            txtkm.Size = new Size(197, 48);
            txtkm.TabIndex = 3;
            // 
            // txyliter
            // 
            txyliter.Font = new Font("Microsoft JhengHei UI", 24F);
            txyliter.Location = new Point(351, 127);
            txyliter.Name = "txyliter";
            txyliter.Size = new Size(197, 48);
            txyliter.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Location = new Point(339, 215);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(209, 60);
            lblshow.TabIndex = 6;
            // 
            // btncalculate
            // 
            btncalculate.Location = new Point(128, 350);
            btncalculate.Name = "btncalculate";
            btncalculate.Size = new Size(128, 63);
            btncalculate.TabIndex = 7;
            btncalculate.Text = "計算";
            btncalculate.UseVisualStyleBackColor = true;
            btncalculate.Click += btncalculate_Click;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(470, 350);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(122, 63);
            btnexit.TabIndex = 8;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnexit);
            Controls.Add(btncalculate);
            Controls.Add(lblshow);
            Controls.Add(txyliter);
            Controls.Add(txtkm);
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
        private TextBox txtkm;
        private TextBox txyliter;
        private Label lblshow;
        private Button btncalculate;
        private Button btnexit;
    }
}
