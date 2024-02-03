
namespace HotelAutomation
{
    partial class Customers
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
            this.btn_room = new System.Windows.Forms.Button();
            this.btn_rezervasyon = new System.Windows.Forms.Button();
            this.btn_out = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.btn_room);
            this.panel1.Controls.Add(this.btn_rezervasyon);
            this.panel1.Controls.Add(this.btn_out);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 649);
            this.panel1.TabIndex = 0;
            // 
            // btn_room
            // 
            this.btn_room.BackColor = System.Drawing.Color.Crimson;
            this.btn_room.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_room.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_room.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_room.Location = new System.Drawing.Point(12, 208);
            this.btn_room.Name = "btn_room";
            this.btn_room.Size = new System.Drawing.Size(133, 63);
            this.btn_room.TabIndex = 3;
            this.btn_room.Text = "Odam";
            this.btn_room.UseVisualStyleBackColor = false;
            this.btn_room.Click += new System.EventHandler(this.btn_room_Click);
            // 
            // btn_rezervasyon
            // 
            this.btn_rezervasyon.BackColor = System.Drawing.Color.Crimson;
            this.btn_rezervasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rezervasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_rezervasyon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_rezervasyon.Location = new System.Drawing.Point(12, 119);
            this.btn_rezervasyon.Name = "btn_rezervasyon";
            this.btn_rezervasyon.Size = new System.Drawing.Size(133, 63);
            this.btn_rezervasyon.TabIndex = 2;
            this.btn_rezervasyon.Text = "Rezervasyon";
            this.btn_rezervasyon.UseVisualStyleBackColor = false;
            this.btn_rezervasyon.Click += new System.EventHandler(this.btn_rezervasyon_Click);
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
            this.btn_out.Click += new System.EventHandler(this.btn_out_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteriler";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 636);
            this.Controls.Add(this.panel1);
            this.Name = "Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon";
            this.Load += new System.EventHandler(this.Musteriler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_out;
        private System.Windows.Forms.Button btn_rezervasyon;
        private System.Windows.Forms.Button btn_room;
    }
}