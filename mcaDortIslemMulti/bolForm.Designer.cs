﻿namespace ryDortIslemMulti
{
    partial class bolForm
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.tbSayi2 = new System.Windows.Forms.TextBox();
            this.tbSayi1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tsBolme = new System.Windows.Forms.ToolStrip();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.tsBolme.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(62, 109);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(126, 31);
            this.btnHesapla.TabIndex = 15;
            this.btnHesapla.Text = "/ ________";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(88, 146);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(100, 24);
            this.tbSonuc.TabIndex = 14;
            this.tbSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSayi2
            // 
            this.tbSayi2.Location = new System.Drawing.Point(88, 79);
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(100, 24);
            this.tbSayi2.TabIndex = 13;
            this.tbSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSayi1
            // 
            this.tbSayi1.Location = new System.Drawing.Point(88, 36);
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(100, 24);
            this.tbSayi1.TabIndex = 12;
            this.tbSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Sonuc :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "2.Sayı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "1.Sayı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsBolme
            // 
            this.tsBolme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsBolme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKapat});
            this.tsBolme.Location = new System.Drawing.Point(0, 0);
            this.tsBolme.Name = "tsBolme";
            this.tsBolme.Size = new System.Drawing.Size(207, 25);
            this.tsBolme.TabIndex = 8;
            this.tsBolme.Text = "toolStrip1";
            // 
            // btnKapat
            // 
            this.btnKapat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnKapat.BackgroundImage = global::ryDortIslemMulti.Properties.Resources.kapat;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnKapat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(23, 22);
            this.btnKapat.ToolTipText = "Program Çıkış";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // bolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 187);
            this.ControlBox = false;
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.tbSayi2);
            this.Controls.Add(this.tbSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsBolme);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "bolForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖRT İŞLEM - BÖLME";
            this.Load += new System.EventHandler(this.bolForm_Load);
            this.tsBolme.ResumeLayout(false);
            this.tsBolme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox tbSonuc;
        private System.Windows.Forms.TextBox tbSayi2;
        private System.Windows.Forms.TextBox tbSayi1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tsBolme;
        private System.Windows.Forms.ToolStripButton btnKapat;
    }
}