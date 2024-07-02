namespace hastane
{
    partial class ilaclist
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
            this.mskdtc = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datailaclist = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datailaclist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(199, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // mskdtc
            // 
            this.mskdtc.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskdtc.Location = new System.Drawing.Point(253, 62);
            this.mskdtc.Mask = "00000000000";
            this.mskdtc.Name = "mskdtc";
            this.mskdtc.Size = new System.Drawing.Size(187, 34);
            this.mskdtc.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(477, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datailaclist
            // 
            this.datailaclist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datailaclist.Location = new System.Drawing.Point(-5, 123);
            this.datailaclist.Name = "datailaclist";
            this.datailaclist.RowHeadersWidth = 51;
            this.datailaclist.RowTemplate.Height = 24;
            this.datailaclist.Size = new System.Drawing.Size(817, 84);
            this.datailaclist.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(-5, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ilaclist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 238);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datailaclist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mskdtc);
            this.Controls.Add(this.label1);
            this.Name = "ilaclist";
            this.Text = "ilaclist";
            ((System.ComponentModel.ISupportInitialize)(this.datailaclist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskdtc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView datailaclist;
        private System.Windows.Forms.Button button2;
    }
}