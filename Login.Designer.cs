
namespace Programming251_Project
{
    partial class Login
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblStn_lgn = new System.Windows.Forms.Label();
            this.lblPwsd_lgn = new System.Windows.Forms.Label();
            this.lblCpwsd_lgn = new System.Windows.Forms.Label();
            this.txtBStn_lgn = new System.Windows.Forms.TextBox();
            this.txtBPwsd_lgn = new System.Windows.Forms.TextBox();
            this.txtBCpwsd_lgn = new System.Windows.Forms.TextBox();
            this.btnLgn = new System.Windows.Forms.Button();
            this.btnClr_lgn = new System.Windows.Forms.Button();
            this.btnExt_lgn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReg_lgn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(166, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(76, 28);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // lblStn_lgn
            // 
            this.lblStn_lgn.AutoSize = true;
            this.lblStn_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStn_lgn.Location = new System.Drawing.Point(45, 69);
            this.lblStn_lgn.Name = "lblStn_lgn";
            this.lblStn_lgn.Size = new System.Drawing.Size(87, 14);
            this.lblStn_lgn.TabIndex = 1;
            this.lblStn_lgn.Text = "Student Number:";
            // 
            // lblPwsd_lgn
            // 
            this.lblPwsd_lgn.AutoSize = true;
            this.lblPwsd_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwsd_lgn.Location = new System.Drawing.Point(45, 99);
            this.lblPwsd_lgn.Name = "lblPwsd_lgn";
            this.lblPwsd_lgn.Size = new System.Drawing.Size(60, 14);
            this.lblPwsd_lgn.TabIndex = 2;
            this.lblPwsd_lgn.Text = "Password:";
            // 
            // lblCpwsd_lgn
            // 
            this.lblCpwsd_lgn.AutoSize = true;
            this.lblCpwsd_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpwsd_lgn.Location = new System.Drawing.Point(45, 133);
            this.lblCpwsd_lgn.Name = "lblCpwsd_lgn";
            this.lblCpwsd_lgn.Size = new System.Drawing.Size(100, 14);
            this.lblCpwsd_lgn.TabIndex = 3;
            this.lblCpwsd_lgn.Text = "Confirm Password:";
            // 
            // txtBStn_lgn
            // 
            this.txtBStn_lgn.Location = new System.Drawing.Point(154, 65);
            this.txtBStn_lgn.Name = "txtBStn_lgn";
            this.txtBStn_lgn.Size = new System.Drawing.Size(151, 20);
            this.txtBStn_lgn.TabIndex = 4;
            // 
            // txtBPwsd_lgn
            // 
            this.txtBPwsd_lgn.Location = new System.Drawing.Point(154, 95);
            this.txtBPwsd_lgn.Name = "txtBPwsd_lgn";
            this.txtBPwsd_lgn.PasswordChar = '*';
            this.txtBPwsd_lgn.Size = new System.Drawing.Size(151, 20);
            this.txtBPwsd_lgn.TabIndex = 5;
            this.txtBPwsd_lgn.TextChanged += new System.EventHandler(this.txtBPwsd_lgn_TextChanged);
            // 
            // txtBCpwsd_lgn
            // 
            this.txtBCpwsd_lgn.Location = new System.Drawing.Point(154, 129);
            this.txtBCpwsd_lgn.Name = "txtBCpwsd_lgn";
            this.txtBCpwsd_lgn.PasswordChar = '*';
            this.txtBCpwsd_lgn.Size = new System.Drawing.Size(151, 20);
            this.txtBCpwsd_lgn.TabIndex = 6;
            this.txtBCpwsd_lgn.TextChanged += new System.EventHandler(this.txtBCpwsd_lgn_TextChanged);
            // 
            // btnLgn
            // 
            this.btnLgn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLgn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgn.Location = new System.Drawing.Point(64, 172);
            this.btnLgn.Name = "btnLgn";
            this.btnLgn.Size = new System.Drawing.Size(84, 30);
            this.btnLgn.TabIndex = 7;
            this.btnLgn.Text = "&Login";
            this.btnLgn.UseVisualStyleBackColor = false;
            this.btnLgn.Click += new System.EventHandler(this.btnLgn_Click);
            // 
            // btnClr_lgn
            // 
            this.btnClr_lgn.BackColor = System.Drawing.Color.Honeydew;
            this.btnClr_lgn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClr_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr_lgn.Location = new System.Drawing.Point(154, 172);
            this.btnClr_lgn.Name = "btnClr_lgn";
            this.btnClr_lgn.Size = new System.Drawing.Size(84, 30);
            this.btnClr_lgn.TabIndex = 8;
            this.btnClr_lgn.Text = "&Clear";
            this.btnClr_lgn.UseVisualStyleBackColor = false;
            // 
            // btnExt_lgn
            // 
            this.btnExt_lgn.BackColor = System.Drawing.Color.Red;
            this.btnExt_lgn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExt_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt_lgn.Location = new System.Drawing.Point(244, 172);
            this.btnExt_lgn.Name = "btnExt_lgn";
            this.btnExt_lgn.Size = new System.Drawing.Size(84, 30);
            this.btnExt_lgn.TabIndex = 9;
            this.btnExt_lgn.Text = "&Exit";
            this.btnExt_lgn.UseVisualStyleBackColor = false;
            this.btnExt_lgn.Click += new System.EventHandler(this.btnExt_lgn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Are you new student?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Click on the button below register...";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnReg_lgn
            // 
            this.btnReg_lgn.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReg_lgn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReg_lgn.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg_lgn.Location = new System.Drawing.Point(143, 277);
            this.btnReg_lgn.Name = "btnReg_lgn";
            this.btnReg_lgn.Size = new System.Drawing.Size(106, 46);
            this.btnReg_lgn.TabIndex = 12;
            this.btnReg_lgn.Text = "&Register";
            this.btnReg_lgn.UseVisualStyleBackColor = false;
            this.btnReg_lgn.Click += new System.EventHandler(this.btnReg_lgn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Message";
            this.label1.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(415, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReg_lgn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExt_lgn);
            this.Controls.Add(this.btnClr_lgn);
            this.Controls.Add(this.btnLgn);
            this.Controls.Add(this.txtBCpwsd_lgn);
            this.Controls.Add(this.txtBPwsd_lgn);
            this.Controls.Add(this.txtBStn_lgn);
            this.Controls.Add(this.lblCpwsd_lgn);
            this.Controls.Add(this.lblPwsd_lgn);
            this.Controls.Add(this.lblStn_lgn);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblStn_lgn;
        private System.Windows.Forms.Label lblPwsd_lgn;
        private System.Windows.Forms.Label lblCpwsd_lgn;
        private System.Windows.Forms.TextBox txtBStn_lgn;
        private System.Windows.Forms.TextBox txtBPwsd_lgn;
        private System.Windows.Forms.TextBox txtBCpwsd_lgn;
        private System.Windows.Forms.Button btnLgn;
        private System.Windows.Forms.Button btnClr_lgn;
        private System.Windows.Forms.Button btnExt_lgn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReg_lgn;
        private System.Windows.Forms.Label label1;
    }
}

