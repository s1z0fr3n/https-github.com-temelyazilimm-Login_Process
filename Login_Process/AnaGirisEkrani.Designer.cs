
namespace Login_Process
{
    partial class AnaGirisEkrani
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
            this.textUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupUI = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textKod = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupKod = new System.Windows.Forms.GroupBox();
            this.btnKod = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupUI.SuspendLayout();
            this.groupKod.SuspendLayout();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(164, 26);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(183, 22);
            this.textUserName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(164, 60);
            this.textPassword.Name = "textPassword";
            this.textPassword.PasswordChar = '*';
            this.textPassword.Size = new System.Drawing.Size(183, 22);
            this.textPassword.TabIndex = 3;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.Location = new System.Drawing.Point(260, 136);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(87, 27);
            this.btnSignIn.TabIndex = 4;
            this.btnSignIn.Text = "Giriş";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(217, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giriş Hakkınız:5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(121, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giriş Hakkınız Kalmamıştır!!!";
            // 
            // groupUI
            // 
            this.groupUI.Controls.Add(this.textPassword);
            this.groupUI.Controls.Add(this.label3);
            this.groupUI.Controls.Add(this.label1);
            this.groupUI.Controls.Add(this.label4);
            this.groupUI.Controls.Add(this.label2);
            this.groupUI.Controls.Add(this.textUserName);
            this.groupUI.Controls.Add(this.btnSignIn);
            this.groupUI.Location = new System.Drawing.Point(34, 12);
            this.groupUI.Name = "groupUI";
            this.groupUI.Size = new System.Drawing.Size(406, 183);
            this.groupUI.TabIndex = 9;
            this.groupUI.TabStop = false;
            this.groupUI.Text = "Kullanıcı Girişi";
            this.groupUI.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(19, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Doğrulama Kodunuz:";
            // 
            // textKod
            // 
            this.textKod.Location = new System.Drawing.Point(248, 75);
            this.textKod.Name = "textKod";
            this.textKod.Size = new System.Drawing.Size(111, 22);
            this.textKod.TabIndex = 11;
            this.textKod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKod.ForeColor = System.Drawing.Color.Red;
            this.lblKod.Location = new System.Drawing.Point(246, 46);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(0, 19);
            this.lblKod.TabIndex = 10;
            this.lblKod.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(90, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kodu Giriniz: ";
            // 
            // groupKod
            // 
            this.groupKod.Controls.Add(this.btnKod);
            this.groupKod.Controls.Add(this.label7);
            this.groupKod.Controls.Add(this.label5);
            this.groupKod.Controls.Add(this.lblKod);
            this.groupKod.Controls.Add(this.textKod);
            this.groupKod.Location = new System.Drawing.Point(57, 302);
            this.groupKod.Name = "groupKod";
            this.groupKod.Size = new System.Drawing.Size(406, 148);
            this.groupKod.TabIndex = 14;
            this.groupKod.TabStop = false;
            this.groupKod.Text = "Doğrulama Ekranı";
            // 
            // btnKod
            // 
            this.btnKod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKod.Location = new System.Drawing.Point(248, 106);
            this.btnKod.Name = "btnKod";
            this.btnKod.Size = new System.Drawing.Size(111, 27);
            this.btnKod.TabIndex = 15;
            this.btnKod.Text = "Kodu Gir";
            this.btnKod.UseVisualStyleBackColor = true;
            this.btnKod.Click += new System.EventHandler(this.btnKod_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(34, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 46);
            this.button1.TabIndex = 15;
            this.button1.Text = "Kullanıcı Bilgilerini Git";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AnaGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(465, 271);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupKod);
            this.Controls.Add(this.groupUI);
            this.Name = "AnaGirisEkrani";
            this.Text = "Kullanıcı Giriş Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupUI.ResumeLayout(false);
            this.groupUI.PerformLayout();
            this.groupKod.ResumeLayout(false);
            this.groupKod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupUI;
        private System.Windows.Forms.TextBox textKod;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupKod;
        private System.Windows.Forms.Button btnKod;
        private System.Windows.Forms.Button button1;
    }
}

