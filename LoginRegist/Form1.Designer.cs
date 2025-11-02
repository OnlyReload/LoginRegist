namespace LoginRegist
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.TextBox();
            this.hard = new System.Windows.Forms.Button();
            this.dyn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label_username
            // 
            this.label_username.Location = new System.Drawing.Point(128, 100);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(100, 20);
            this.label_username.TabIndex = 3;
            // 
            // label_password
            // 
            this.label_password.Location = new System.Drawing.Point(128, 146);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(100, 20);
            this.label_password.TabIndex = 4;
            // 
            // hard
            // 
            this.hard.Location = new System.Drawing.Point(128, 189);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(112, 23);
            this.hard.TabIndex = 5;
            this.hard.Text = "regist hard code";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // dyn
            // 
            this.dyn.Location = new System.Drawing.Point(128, 243);
            this.dyn.Name = "dyn";
            this.dyn.Size = new System.Drawing.Size(112, 23);
            this.dyn.TabIndex = 6;
            this.dyn.Text = "regist dynamic code";
            this.dyn.UseVisualStyleBackColor = true;
            this.dyn.Click += new System.EventHandler(this.dyn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dyn);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox label_username;
        private System.Windows.Forms.TextBox label_password;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button dyn;
    }
}

