namespace BirKelimeBirIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSayiEllegir = new System.Windows.Forms.Button();
            this.btnSayiRandom = new System.Windows.Forms.Button();
            this.btnKelimeEllegir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKelimeRandom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(449, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "BİR İŞLEM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "BİR KELİME";
            // 
            // btnSayiEllegir
            // 
            this.btnSayiEllegir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSayiEllegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiEllegir.Location = new System.Drawing.Point(506, 320);
            this.btnSayiEllegir.Name = "btnSayiEllegir";
            this.btnSayiEllegir.Size = new System.Drawing.Size(101, 65);
            this.btnSayiEllegir.TabIndex = 14;
            this.btnSayiEllegir.Text = "SAYİ ELLE GİR";
            this.btnSayiEllegir.UseVisualStyleBackColor = false;
            this.btnSayiEllegir.Click += new System.EventHandler(this.btnSayiEllegir_Click);
            // 
            // btnSayiRandom
            // 
            this.btnSayiRandom.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSayiRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayiRandom.Location = new System.Drawing.Point(393, 320);
            this.btnSayiRandom.Name = "btnSayiRandom";
            this.btnSayiRandom.Size = new System.Drawing.Size(96, 65);
            this.btnSayiRandom.TabIndex = 13;
            this.btnSayiRandom.Text = "SAYI RANDOM";
            this.btnSayiRandom.UseVisualStyleBackColor = false;
            this.btnSayiRandom.Click += new System.EventHandler(this.btnSayiRandom_Click);
            // 
            // btnKelimeEllegir
            // 
            this.btnKelimeEllegir.BackColor = System.Drawing.Color.Sienna;
            this.btnKelimeEllegir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeEllegir.Location = new System.Drawing.Point(154, 322);
            this.btnKelimeEllegir.Name = "btnKelimeEllegir";
            this.btnKelimeEllegir.Size = new System.Drawing.Size(99, 61);
            this.btnKelimeEllegir.TabIndex = 12;
            this.btnKelimeEllegir.Text = "KELİME ELLE GİR";
            this.btnKelimeEllegir.UseVisualStyleBackColor = false;
            this.btnKelimeEllegir.Click += new System.EventHandler(this.btnKelimeEllegir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Devam etmek istediğiniz bölümü seçiniz...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(136, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "BİR KELİME ";
            // 
            // btnKelimeRandom
            // 
            this.btnKelimeRandom.BackColor = System.Drawing.Color.Sienna;
            this.btnKelimeRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeRandom.Location = new System.Drawing.Point(35, 324);
            this.btnKelimeRandom.Name = "btnKelimeRandom";
            this.btnKelimeRandom.Size = new System.Drawing.Size(101, 61);
            this.btnKelimeRandom.TabIndex = 9;
            this.btnKelimeRandom.Text = "KELİME RANDOM";
            this.btnKelimeRandom.UseVisualStyleBackColor = false;
            this.btnKelimeRandom.Click += new System.EventHandler(this.btnKelimeRandom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 162);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(293, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(323, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 33);
            this.label5.TabIndex = 19;
            this.label5.Text = "BİR İŞLEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(733, 491);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSayiEllegir);
            this.Controls.Add(this.btnSayiRandom);
            this.Controls.Add(this.btnKelimeEllegir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKelimeRandom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSayiEllegir;
        private System.Windows.Forms.Button btnSayiRandom;
        private System.Windows.Forms.Button btnKelimeEllegir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKelimeRandom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
    }
}

