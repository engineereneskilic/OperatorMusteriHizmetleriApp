﻿namespace Final_Projesi_İki_Ders_Bir_Arada_
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menu_label = new System.Windows.Forms.Label();
            this.onayla_button = new System.Windows.Forms.Button();
            this.seciminiz_kutusu = new System.Windows.Forms.TextBox();
            this.seciminiz_label = new System.Windows.Forms.Label();
            this.karsilama_label3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.kullanici_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menu_label
            // 
            this.menu_label.AutoSize = true;
            this.menu_label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.menu_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(125)))), ((int)(((byte)(132)))));
            this.menu_label.Location = new System.Drawing.Point(16, 38);
            this.menu_label.Name = "menu_label";
            this.menu_label.Size = new System.Drawing.Size(49, 20);
            this.menu_label.TabIndex = 15;
            this.menu_label.Text = "menu";
            // 
            // onayla_button
            // 
            this.onayla_button.BackColor = System.Drawing.Color.Firebrick;
            this.onayla_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onayla_button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.onayla_button.Location = new System.Drawing.Point(217, 188);
            this.onayla_button.Name = "onayla_button";
            this.onayla_button.Size = new System.Drawing.Size(146, 30);
            this.onayla_button.TabIndex = 14;
            this.onayla_button.Text = "Onayla";
            this.onayla_button.UseVisualStyleBackColor = false;
            this.onayla_button.Click += new System.EventHandler(this.onayla_button_Click_1);
            // 
            // seciminiz_kutusu
            // 
            this.seciminiz_kutusu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.seciminiz_kutusu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.seciminiz_kutusu.Location = new System.Drawing.Point(113, 190);
            this.seciminiz_kutusu.Name = "seciminiz_kutusu";
            this.seciminiz_kutusu.Size = new System.Drawing.Size(98, 27);
            this.seciminiz_kutusu.TabIndex = 13;
            // 
            // seciminiz_label
            // 
            this.seciminiz_label.AutoSize = true;
            this.seciminiz_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.seciminiz_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.seciminiz_label.Location = new System.Drawing.Point(15, 192);
            this.seciminiz_label.Name = "seciminiz_label";
            this.seciminiz_label.Size = new System.Drawing.Size(92, 21);
            this.seciminiz_label.TabIndex = 12;
            this.seciminiz_label.Text = "Seçiminiz: ";
            // 
            // karsilama_label3
            // 
            this.karsilama_label3.AutoSize = true;
            this.karsilama_label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.karsilama_label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.karsilama_label3.Location = new System.Drawing.Point(12, 9);
            this.karsilama_label3.Name = "karsilama_label3";
            this.karsilama_label3.Size = new System.Drawing.Size(213, 28);
            this.karsilama_label3.TabIndex = 11;
            this.karsilama_label3.Text = "ECO KAMPANYALARI";
            // 
            // timer3
            // 
            this.timer3.Interval = 3000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // kullanici_label
            // 
            this.kullanici_label.AutoSize = true;
            this.kullanici_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.kullanici_label.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.kullanici_label.Location = new System.Drawing.Point(419, 198);
            this.kullanici_label.Name = "kullanici_label";
            this.kullanici_label.Size = new System.Drawing.Size(98, 15);
            this.kullanici_label.TabIndex = 16;
            this.kullanici_label.Text = "Kullanıcı Bilgileri";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(570, 230);
            this.Controls.Add(this.kullanici_label);
            this.Controls.Add(this.menu_label);
            this.Controls.Add(this.onayla_button);
            this.Controls.Add(this.seciminiz_kutusu);
            this.Controls.Add(this.seciminiz_label);
            this.Controls.Add(this.karsilama_label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(570, 230);
            this.MinimumSize = new System.Drawing.Size(570, 230);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Türk Telekom Kampanyaları";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menu_label;
        private System.Windows.Forms.Button onayla_button;
        private System.Windows.Forms.TextBox seciminiz_kutusu;
        private System.Windows.Forms.Label seciminiz_label;
        private System.Windows.Forms.Label karsilama_label3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label kullanici_label;
    }
}