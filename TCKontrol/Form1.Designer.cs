namespace TCKontrol
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTC = new System.Windows.Forms.TextBox();
			this.txtAD = new System.Windows.Forms.TextBox();
			this.txtSOYAD = new System.Windows.Forms.TextBox();
			this.txtYIL = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "TC";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "AD";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "SOYAD";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "YIL";
			// 
			// txtTC
			// 
			this.txtTC.Location = new System.Drawing.Point(84, 38);
			this.txtTC.Name = "txtTC";
			this.txtTC.Size = new System.Drawing.Size(126, 20);
			this.txtTC.TabIndex = 1;
			// 
			// txtAD
			// 
			this.txtAD.Location = new System.Drawing.Point(84, 64);
			this.txtAD.Name = "txtAD";
			this.txtAD.Size = new System.Drawing.Size(126, 20);
			this.txtAD.TabIndex = 1;
			// 
			// txtSOYAD
			// 
			this.txtSOYAD.Location = new System.Drawing.Point(84, 90);
			this.txtSOYAD.Name = "txtSOYAD";
			this.txtSOYAD.Size = new System.Drawing.Size(126, 20);
			this.txtSOYAD.TabIndex = 1;
			// 
			// txtYIL
			// 
			this.txtYIL.Location = new System.Drawing.Point(84, 116);
			this.txtYIL.Name = "txtYIL";
			this.txtYIL.Size = new System.Drawing.Size(126, 20);
			this.txtYIL.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(84, 142);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 34);
			this.button1.TabIndex = 2;
			this.button1.Text = "KAYDET";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 190);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtYIL);
			this.Controls.Add(this.txtSOYAD);
			this.Controls.Add(this.txtAD);
			this.Controls.Add(this.txtTC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTC;
		private System.Windows.Forms.TextBox txtAD;
		private System.Windows.Forms.TextBox txtSOYAD;
		private System.Windows.Forms.TextBox txtYIL;
		private System.Windows.Forms.Button button1;
	}
}

