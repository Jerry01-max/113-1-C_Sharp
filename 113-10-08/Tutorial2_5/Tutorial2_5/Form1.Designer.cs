namespace Tutorial2_5
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
            ptxfront = new PictureBox();
            ptxBack = new PictureBox();
            btnback = new Button();
            btnfront = new Button();
            btnexit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxfront).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            SuspendLayout();
            // 
            // ptxfront
            // 
            ptxfront.Image = Properties.Resources.Ace_Spades;
            ptxfront.Location = new Point(74, 93);
            ptxfront.Name = "ptxfront";
            ptxfront.Size = new Size(154, 196);
            ptxfront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxfront.TabIndex = 0;
            ptxfront.TabStop = false;
            ptxfront.Visible = false;
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(353, 93);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(154, 196);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 1;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // btnback
            // 
            btnback.Location = new Point(372, 323);
            btnback.Name = "btnback";
            btnback.Size = new Size(123, 51);
            btnback.TabIndex = 2;
            btnback.Text = "背面";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // btnfront
            // 
            btnfront.Location = new Point(85, 323);
            btnfront.Name = "btnfront";
            btnfront.Size = new Size(126, 51);
            btnfront.TabIndex = 3;
            btnfront.Text = "正面";
            btnfront.UseVisualStyleBackColor = true;
            btnfront.Click += btnfront_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 20F);
            btnexit.Location = new Point(153, 448);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(275, 53);
            btnexit.TabIndex = 4;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 563);
            Controls.Add(btnexit);
            Controls.Add(btnfront);
            Controls.Add(btnback);
            Controls.Add(ptxBack);
            Controls.Add(ptxfront);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxfront).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxfront;
        private PictureBox ptxBack;
        private Button btnback;
        private Button btnfront;
        private Button btnexit;
    }
}
