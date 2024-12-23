namespace denemeform_
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
            button1 = new Button();
            snc = new Label();
            ad = new Label();
            email_txt = new TextBox();
            email = new Label();
            txt_s1 = new TextBox();
            txt_s2 = new TextBox();
            snc1 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(389, 330);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // snc
            // 
            snc.AutoSize = true;
            snc.Location = new Point(389, 111);
            snc.Name = "snc";
            snc.Size = new Size(49, 20);
            snc.TabIndex = 1;
            snc.Text = "Sonuç";
            // 
            // ad
            // 
            ad.AutoSize = true;
            ad.Location = new Point(389, 144);
            ad.Name = "ad";
            ad.Size = new Size(26, 20);
            ad.TabIndex = 2;
            ad.Text = "ad";
            // 
            // email_txt
            // 
            email_txt.Location = new Point(45, 71);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(125, 27);
            email_txt.TabIndex = 3;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(389, 185);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 4;
            email.Text = "email";
            // 
            // txt_s1
            // 
            txt_s1.Location = new Point(45, 121);
            txt_s1.Name = "txt_s1";
            txt_s1.Size = new Size(125, 27);
            txt_s1.TabIndex = 5;
            // 
            // txt_s2
            // 
            txt_s2.AccessibleDescription = "";
            txt_s2.Location = new Point(45, 169);
            txt_s2.Name = "txt_s2";
            txt_s2.Size = new Size(125, 27);
            txt_s2.TabIndex = 6;
            txt_s2.Tag = "";
            // 
            // snc1
            // 
            snc1.AutoSize = true;
            snc1.Location = new Point(389, 78);
            snc1.Name = "snc1";
            snc1.Size = new Size(49, 20);
            snc1.TabIndex = 7;
            snc1.Text = "Sonuç";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 48);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 98);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 9;
            label2.Text = "Sayı1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 151);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 10;
            label3.Text = "Sayı2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(snc1);
            Controls.Add(txt_s2);
            Controls.Add(txt_s1);
            Controls.Add(email);
            Controls.Add(email_txt);
            Controls.Add(ad);
            Controls.Add(snc);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label snc;
        private Label ad;
        private TextBox email_txt;
        private Label email;
        private TextBox txt_s1;
        private TextBox txt_s2;
        private Label snc1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
