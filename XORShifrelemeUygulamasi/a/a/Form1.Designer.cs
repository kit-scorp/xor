namespace XORShifrelemeUygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBoxAnahtar = new System.Windows.Forms.RichTextBox();
            this.richTextBoxMetin = new System.Windows.Forms.RichTextBox();
            this.buttonSifrele = new System.Windows.Forms.Button();
            this.buttonCoz = new System.Windows.Forms.Button();
            this.richTextBoxSifrelimetin = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCozulmusMetin = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxAnahtar
            // 
            this.richTextBoxAnahtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxAnahtar.Location = new System.Drawing.Point(309, 195);
            this.richTextBoxAnahtar.Name = "richTextBoxAnahtar";
            this.richTextBoxAnahtar.Size = new System.Drawing.Size(143, 33);
            this.richTextBoxAnahtar.TabIndex = 0;
            this.richTextBoxAnahtar.Text = "";
            // 
            // richTextBoxMetin
            // 
            this.richTextBoxMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxMetin.Location = new System.Drawing.Point(309, 251);
            this.richTextBoxMetin.Name = "richTextBoxMetin";
            this.richTextBoxMetin.Size = new System.Drawing.Size(143, 33);
            this.richTextBoxMetin.TabIndex = 1;
            this.richTextBoxMetin.Text = "";
            // 
            // buttonSifrele
            // 
            this.buttonSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSifrele.Location = new System.Drawing.Point(500, 192);
            this.buttonSifrele.Name = "buttonSifrele";
            this.buttonSifrele.Size = new System.Drawing.Size(151, 36);
            this.buttonSifrele.TabIndex = 2;
            this.buttonSifrele.Text = "şifrele";
            this.buttonSifrele.UseVisualStyleBackColor = true;
            this.buttonSifrele.Click += new System.EventHandler(this.buttonSifrele_Click);
            // 
            // buttonCoz
            // 
            this.buttonCoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCoz.Location = new System.Drawing.Point(500, 251);
            this.buttonCoz.Name = "buttonCoz";
            this.buttonCoz.Size = new System.Drawing.Size(151, 36);
            this.buttonCoz.TabIndex = 3;
            this.buttonCoz.Text = "çöz";
            this.buttonCoz.UseVisualStyleBackColor = true;
            this.buttonCoz.Click += new System.EventHandler(this.buttonCoz_Click);
            // 
            // richTextBoxSifrelimetin
            // 
            this.richTextBoxSifrelimetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxSifrelimetin.Location = new System.Drawing.Point(283, 400);
            this.richTextBoxSifrelimetin.Name = "richTextBoxSifrelimetin";
            this.richTextBoxSifrelimetin.Size = new System.Drawing.Size(143, 31);
            this.richTextBoxSifrelimetin.TabIndex = 4;
            this.richTextBoxSifrelimetin.Text = "";
            // 
            // richTextBoxCozulmusMetin
            // 
            this.richTextBoxCozulmusMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBoxCozulmusMetin.Location = new System.Drawing.Point(283, 462);
            this.richTextBoxCozulmusMetin.Name = "richTextBoxCozulmusMetin";
            this.richTextBoxCozulmusMetin.Size = new System.Drawing.Size(143, 31);
            this.richTextBoxCozulmusMetin.TabIndex = 5;
            this.richTextBoxCozulmusMetin.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "şifrelenmiş metin :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(77, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "çözülmüş metin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "şifrelenecek metni giriniz :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "şifrelenecek anahtarı giriniz :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(282, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 100);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(120, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 42);
            this.label5.TabIndex = 0;
            this.label5.Text = "şifreleme";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxCozulmusMetin);
            this.Controls.Add(this.richTextBoxSifrelimetin);
            this.Controls.Add(this.buttonCoz);
            this.Controls.Add(this.buttonSifrele);
            this.Controls.Add(this.richTextBoxMetin);
            this.Controls.Add(this.richTextBoxAnahtar);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxAnahtar;
        private System.Windows.Forms.RichTextBox richTextBoxMetin;
        private System.Windows.Forms.Button buttonSifrele;
        private System.Windows.Forms.Button buttonCoz;
        private System.Windows.Forms.RichTextBox richTextBoxSifrelimetin;
        private System.Windows.Forms.RichTextBox richTextBoxCozulmusMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
    }
}

