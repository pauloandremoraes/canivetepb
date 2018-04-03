namespace Addons
{
    partial class EscolherEmpresa
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbTypeServer = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbServer = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpresa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuserbd = new System.Windows.Forms.TextBox();
            this.txtsenhabd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTypeServer
            // 
            this.cbTypeServer.FormattingEnabled = true;
            this.cbTypeServer.Items.AddRange(new object[] {
            "MSSQL2008",
            "MSSQL2012",
            "MSSQL2014"});
            this.cbTypeServer.Location = new System.Drawing.Point(86, 135);
            this.cbTypeServer.Name = "cbTypeServer";
            this.cbTypeServer.Size = new System.Drawing.Size(147, 21);
            this.cbTypeServer.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(86, 29);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(86, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Server:";
            // 
            // cbServer
            // 
            this.cbServer.FormattingEnabled = true;
            this.cbServer.Items.AddRange(new object[] {
            "SRVEVOSAP01"});
            this.cbServer.Location = new System.Drawing.Point(86, 162);
            this.cbServer.Name = "cbServer";
            this.cbServer.Size = new System.Drawing.Size(147, 21);
            this.cbServer.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Empresa:";
            // 
            // cbEmpresa
            // 
            this.cbEmpresa.FormattingEnabled = true;
            this.cbEmpresa.Items.AddRange(new object[] {
            "SBO_EVO_SA"});
            this.cbEmpresa.Location = new System.Drawing.Point(86, 194);
            this.cbEmpresa.Name = "cbEmpresa";
            this.cbEmpresa.Size = new System.Drawing.Size(147, 21);
            this.cbEmpresa.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 13;
            // 
            // txtuserbd
            // 
            this.txtuserbd.Location = new System.Drawing.Point(86, 82);
            this.txtuserbd.Name = "txtuserbd";
            this.txtuserbd.Size = new System.Drawing.Size(100, 20);
            this.txtuserbd.TabIndex = 14;
            // 
            // txtsenhabd
            // 
            this.txtsenhabd.Location = new System.Drawing.Point(86, 109);
            this.txtsenhabd.Name = "txtsenhabd";
            this.txtsenhabd.Size = new System.Drawing.Size(100, 20);
            this.txtsenhabd.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Usuário BD:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Senha Bd:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // EscolherEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 229);
            this.Controls.Add(this.txtsenhabd);
            this.Controls.Add(this.txtuserbd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbServer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.cbTypeServer);
            this.Controls.Add(this.button1);
            this.Name = "EscolherEmpresa";
            this.Text = "EscolherEmpresa";
            this.Load += new System.EventHandler(this.EscolherEmpresa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbTypeServer;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpresa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtuserbd;
        private System.Windows.Forms.TextBox txtsenhabd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}