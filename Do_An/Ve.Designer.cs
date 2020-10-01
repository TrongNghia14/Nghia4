namespace Do_An {
	partial class Ve {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.panel1 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGVVe = new System.Windows.Forms.DataGridView();
			this.mave = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGVVe)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Teal;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(656, 58);
			this.panel1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Teal;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Image = global::Do_An.Properties.Resources.imgTroVe_50x50;
			this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button2.Location = new System.Drawing.Point(538, 6);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 47);
			this.button2.TabIndex = 4;
			this.button2.Text = "Back";
			this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(67, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Danh sách vé";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Do_An.Properties.Resources.imgHopDongNV_50x50_1;
			this.pictureBox1.Location = new System.Drawing.Point(6, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(55, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// dataGVVe
			// 
			this.dataGVVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGVVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mave,
            this.dongia});
			this.dataGVVe.Location = new System.Drawing.Point(5, 69);
			this.dataGVVe.Name = "dataGVVe";
			this.dataGVVe.Size = new System.Drawing.Size(645, 210);
			this.dataGVVe.TabIndex = 2;
			// 
			// mave
			// 
			this.mave.DataPropertyName = "MAVE";
			this.mave.HeaderText = "Mã vé";
			this.mave.Name = "mave";
			this.mave.ReadOnly = true;
			this.mave.Width = 300;
			// 
			// dongia
			// 
			this.dongia.DataPropertyName = "DONGIA";
			this.dongia.HeaderText = "Đơn giá";
			this.dongia.Name = "dongia";
			this.dongia.ReadOnly = true;
			this.dongia.Width = 300;
			// 
			// Ve
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(80)))));
			this.ClientSize = new System.Drawing.Size(660, 294);
			this.Controls.Add(this.dataGVVe);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Ve";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ve";
			this.Load += new System.EventHandler(this.Ve_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGVVe)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGVVe;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataGridViewTextBoxColumn mave;
		private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
	}
}