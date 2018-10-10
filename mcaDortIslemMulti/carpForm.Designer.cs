namespace ryDortIslemMulti
{
    partial class carpForm
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
            this.tsCarp = new System.Windows.Forms.ToolStrip();
            this.btnKapat = new System.Windows.Forms.ToolStripButton();
            this.tsCarp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(62, 115);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(126, 31);
            this.btnHesapla.TabIndex = 23;
            this.btnHesapla.Text = "X ________";
            this.btnHesapla.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(88, 152);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.Size = new System.Drawing.Size(100, 24);
            this.tbSonuc.TabIndex = 22;
            this.tbSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSayi2
            // 
            this.tbSayi2.Location = new System.Drawing.Point(88, 85);
            this.tbSayi2.Name = "tbSayi2";
            this.tbSayi2.Size = new System.Drawing.Size(100, 24);
            this.tbSayi2.TabIndex = 21;
            this.tbSayi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbSayi1
            // 
            this.tbSayi1.Location = new System.Drawing.Point(88, 42);
            this.tbSayi1.Name = "tbSayi1";
            this.tbSayi1.Size = new System.Drawing.Size(100, 24);
            this.tbSayi1.TabIndex = 20;
            this.tbSayi1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sonuc :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "2.Sayı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "1.Sayı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsCarp
            // 
            this.tsCarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tsCarp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnKapat});
            this.tsCarp.Location = new System.Drawing.Point(0, 0);
            this.tsCarp.Name = "tsCarp";
            this.tsCarp.Size = new System.Drawing.Size(237, 25);
            this.tsCarp.TabIndex = 16;
            this.tsCarp.Text = "toolStrip1";
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
            // carpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.tbSayi2);
            this.Controls.Add(this.tbSayi1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsCarp);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "carpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖRT İŞLEM - ÇARPMA";
            this.tsCarp.ResumeLayout(false);
            this.tsCarp.PerformLayout();
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
        private System.Windows.Forms.ToolStrip tsCarp;
        private System.Windows.Forms.ToolStripButton btnKapat;
    }
}