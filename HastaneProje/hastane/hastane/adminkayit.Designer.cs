namespace hastane
{
    partial class adminkayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.mskdtc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(230, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(179, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(227, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(200, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 39);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // txtad
            // 
            this.txtad.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.Location = new System.Drawing.Point(333, 120);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(195, 38);
            this.txtad.TabIndex = 4;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.Location = new System.Drawing.Point(333, 185);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(195, 38);
            this.txtsoyad.TabIndex = 5;
            // 
            // txtsifre
            // 
            this.txtsifre.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsifre.Location = new System.Drawing.Point(333, 332);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(195, 38);
            this.txtsifre.TabIndex = 7;
            // 
            // mskdtc
            // 
            this.mskdtc.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtc.Location = new System.Drawing.Point(333, 260);
            this.mskdtc.Mask = "00000000000";
            this.mskdtc.Name = "mskdtc";
            this.mskdtc.Size = new System.Drawing.Size(195, 38);
            this.mskdtc.TabIndex = 8;
            this.mskdtc.ValidatingType = typeof(int);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(618, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 83);
            this.button1.TabIndex = 9;
            this.button1.Text = "KAYIT OL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(-2, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // adminkayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(850, 493);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskdtc);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminkayit";
            this.Text = "adminkayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox mskdtc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}