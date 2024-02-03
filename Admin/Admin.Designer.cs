
namespace HotelAutomation
{
    partial class Admin
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
            this.btn_adminRegister = new System.Windows.Forms.Button();
            this.btn_adminRooms = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btn_adminRegister);
            this.panel1.Controls.Add(this.btn_adminRooms);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 649);
            this.panel1.TabIndex = 1;
            // 
            // btn_adminRegister
            // 
            this.btn_adminRegister.BackColor = System.Drawing.Color.Crimson;
            this.btn_adminRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_adminRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminRegister.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adminRegister.Location = new System.Drawing.Point(12, 199);
            this.btn_adminRegister.Name = "btn_adminRegister";
            this.btn_adminRegister.Size = new System.Drawing.Size(133, 63);
            this.btn_adminRegister.TabIndex = 5;
            this.btn_adminRegister.Text = "Admin Kayıt";
            this.btn_adminRegister.UseVisualStyleBackColor = false;
            this.btn_adminRegister.Click += new System.EventHandler(this.btn_adminRegister_Click);
            // 
            // btn_adminRooms
            // 
            this.btn_adminRooms.BackColor = System.Drawing.Color.Crimson;
            this.btn_adminRooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_adminRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_adminRooms.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_adminRooms.Location = new System.Drawing.Point(12, 110);
            this.btn_adminRooms.Name = "btn_adminRooms";
            this.btn_adminRooms.Size = new System.Drawing.Size(133, 63);
            this.btn_adminRooms.TabIndex = 4;
            this.btn_adminRooms.Text = "Odalar";
            this.btn_adminRooms.UseVisualStyleBackColor = false;
            this.btn_adminRooms.Click += new System.EventHandler(this.btn_adminRooms_Click);
            // 
            // btn_out
            // 
            this.btn_out.BackColor = System.Drawing.Color.Transparent;
            this.btn_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_out.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_out.Location = new System.Drawing.Point(12, 591);
            this.btn_out.Name = "btn_out";
            this.btn_out.Size = new System.Drawing.Size(133, 37);
            this.btn_out.TabIndex = 1;
            this.btn_out.Text = "Çıkış";
            this.btn_out.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 636);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_adminRooms;
        private System.Windows.Forms.Button btn_adminRegister;
    }
}