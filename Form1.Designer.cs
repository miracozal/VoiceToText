namespace VoiceToText
{
    partial class Form1
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
            this.selectMp3BT = new System.Windows.Forms.Button();
            this.cikisButonu = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "mp3 dosyası : ";
            // 
            // selectMp3BT
            // 
            this.selectMp3BT.BackColor = System.Drawing.Color.Bisque;
            this.selectMp3BT.Location = new System.Drawing.Point(407, 63);
            this.selectMp3BT.Name = "selectMp3BT";
            this.selectMp3BT.Size = new System.Drawing.Size(223, 68);
            this.selectMp3BT.TabIndex = 1;
            this.selectMp3BT.Text = "Seç";
            this.selectMp3BT.UseVisualStyleBackColor = false;
            this.selectMp3BT.Click += new System.EventHandler(this.selectMp3BT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(407, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(911, 565);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "text : ";

            this.cikisButonu.BackColor = System.Drawing.Color.Brown;
            this.cikisButonu.Location = new System.Drawing.Point(180, 400);
            this.cikisButonu.Name = "cikisBtn";
            this.cikisButonu.Size = new System.Drawing.Size(223, 68);
            this.cikisButonu.TabIndex = 1;
            this.cikisButonu.Text = "Çıkış";
            this.cikisButonu.UseVisualStyleBackColor = false;
            this.cikisButonu.Click += new System.EventHandler(this.cikisButon_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(28F, 55F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(574, 529);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.selectMp3BT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cikisButonu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mp3 to voice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectMp3BT;
        private System.Windows.Forms.Button cikisButonu;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
    }
}

