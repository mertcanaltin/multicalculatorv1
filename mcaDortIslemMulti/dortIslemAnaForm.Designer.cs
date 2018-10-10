namespace ryDortIslemMulti
{
    partial class dortIslemAnaForm
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
            this.buttonToplama = new System.Windows.Forms.Button();
            this.buttonCikarma = new System.Windows.Forms.Button();
            this.buttonCarpma = new System.Windows.Forms.Button();
            this.buttonBolme = new System.Windows.Forms.Button();
            this.buttoniSLEM = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.lblİslem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToplama
            // 
            this.buttonToplama.Location = new System.Drawing.Point(41, 66);
            this.buttonToplama.Name = "buttonToplama";
            this.buttonToplama.Size = new System.Drawing.Size(122, 78);
            this.buttonToplama.TabIndex = 0;
            this.buttonToplama.Text = "+";
            this.buttonToplama.UseVisualStyleBackColor = true;
            this.buttonToplama.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCikarma
            // 
            this.buttonCikarma.Location = new System.Drawing.Point(196, 43);
            this.buttonCikarma.Name = "buttonCikarma";
            this.buttonCikarma.Size = new System.Drawing.Size(133, 101);
            this.buttonCikarma.TabIndex = 1;
            this.buttonCikarma.Text = "-";
            this.buttonCikarma.UseVisualStyleBackColor = true;
            this.buttonCikarma.Click += new System.EventHandler(this.buttonCikarma_Click);
            // 
            // buttonCarpma
            // 
            this.buttonCarpma.Location = new System.Drawing.Point(41, 180);
            this.buttonCarpma.Name = "buttonCarpma";
            this.buttonCarpma.Size = new System.Drawing.Size(122, 81);
            this.buttonCarpma.TabIndex = 2;
            this.buttonCarpma.Text = "*";
            this.buttonCarpma.UseVisualStyleBackColor = true;
            this.buttonCarpma.Click += new System.EventHandler(this.buttonCarpma_Click);
            // 
            // buttonBolme
            // 
            this.buttonBolme.Location = new System.Drawing.Point(196, 180);
            this.buttonBolme.Name = "buttonBolme";
            this.buttonBolme.Size = new System.Drawing.Size(166, 105);
            this.buttonBolme.TabIndex = 3;
            this.buttonBolme.Text = "/";
            this.buttonBolme.UseVisualStyleBackColor = true;
            this.buttonBolme.Click += new System.EventHandler(this.buttonBolme_Click);
            // 
            // buttoniSLEM
            // 
            this.buttoniSLEM.Location = new System.Drawing.Point(393, 54);
            this.buttoniSLEM.Name = "buttoniSLEM";
            this.buttoniSLEM.Size = new System.Drawing.Size(75, 78);
            this.buttoniSLEM.TabIndex = 4;
            this.buttoniSLEM.Text = "iŞLEM lİSTESİ";
            this.buttoniSLEM.UseVisualStyleBackColor = true;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(393, 209);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(75, 52);
            this.buttonCikis.TabIndex = 5;
            this.buttonCikis.Text = "EXİT FORM ";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblİslem
            // 
            this.lblİslem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblİslem.Location = new System.Drawing.Point(12, 307);
            this.lblİslem.Name = "lblİslem";
            this.lblİslem.Size = new System.Drawing.Size(473, 23);
            this.lblİslem.TabIndex = 6;
            this.lblİslem.Text = "İşlem Sonucu";
            // 
            // dortIslemAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 339);
            this.ControlBox = false;
            this.Controls.Add(this.lblİslem);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttoniSLEM);
            this.Controls.Add(this.buttonBolme);
            this.Controls.Add(this.buttonCarpma);
            this.Controls.Add(this.buttonCikarma);
            this.Controls.Add(this.buttonToplama);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dortIslemAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DÖRT İŞLEM";
            this.Load += new System.EventHandler(this.dortIslemAnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonToplama;
        private System.Windows.Forms.Button buttonCikarma;
        private System.Windows.Forms.Button buttonCarpma;
        private System.Windows.Forms.Button buttonBolme;
        private System.Windows.Forms.Button buttoniSLEM;
        private System.Windows.Forms.Button buttonCikis;
        public System.Windows.Forms.Label lblİslem;
    }
}

