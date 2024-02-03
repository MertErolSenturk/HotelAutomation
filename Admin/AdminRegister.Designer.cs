
namespace HotelAutomation
{
    partial class AdminRegister
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.text_userName = new System.Windows.Forms.TextBox();
            this.s = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(482, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 469);
            this.panel1.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Crimson;
            this.btn_register.Font = new System.Drawing.Font("Oswald", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(13, 294);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(324, 53);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "Kaydet";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(13, 236);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(324, 37);
            this.txt_password.TabIndex = 11;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // text_userName
            // 
            this.text_userName.BackColor = System.Drawing.SystemColors.Window;
            this.text_userName.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_userName.Location = new System.Drawing.Point(13, 160);
            this.text_userName.Name = "text_userName";
            this.text_userName.Size = new System.Drawing.Size(324, 37);
            this.text_userName.TabIndex = 10;
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.s.ForeColor = System.Drawing.Color.Black;
            this.s.Location = new System.Drawing.Point(9, 209);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(47, 24);
            this.s.TabIndex = 9;
            this.s.Text = "Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(3, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 55);
            this.label2.TabIndex = 14;
            this.label2.Text = "ADMİN EKLE";
            // 
            // AdminRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 420);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.text_userName);
            this.Controls.Add(this.s);
            this.Controls.Add(this.panel1);
            this.Name = "AdminRegister";
            this.Text = "AdminRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox text_userName;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label2;
    }
}