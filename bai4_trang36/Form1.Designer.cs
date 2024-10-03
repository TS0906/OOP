namespace bai4_trang36
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.txtGiay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaynew = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKq = new System.Windows.Forms.TextBox();
            this.butCong = new System.Windows.Forms.Button();
            this.butTru = new System.Windows.Forms.Button();
            this.butCong1 = new System.Windows.Forms.Button();
            this.butTru1 = new System.Windows.Forms.Button();
            this.butNhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtThoigian = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập giờ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập phút";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập giây";
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(170, 73);
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(100, 22);
            this.txtGio.TabIndex = 1;
            // 
            // txtPhut
            // 
            this.txtPhut.Location = new System.Drawing.Point(170, 114);
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(100, 22);
            this.txtPhut.TabIndex = 1;
            // 
            // txtGiay
            // 
            this.txtGiay.Location = new System.Drawing.Point(170, 158);
            this.txtGiay.Name = "txtGiay";
            this.txtGiay.Size = new System.Drawing.Size(100, 22);
            this.txtGiay.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập số giây";
            // 
            // txtGiaynew
            // 
            this.txtGiaynew.Location = new System.Drawing.Point(170, 237);
            this.txtGiaynew.Name = "txtGiaynew";
            this.txtGiaynew.Size = new System.Drawing.Size(100, 22);
            this.txtGiaynew.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết Quả";
            // 
            // txtKq
            // 
            this.txtKq.Location = new System.Drawing.Point(570, 119);
            this.txtKq.Name = "txtKq";
            this.txtKq.Size = new System.Drawing.Size(100, 22);
            this.txtKq.TabIndex = 5;
            // 
            // butCong
            // 
            this.butCong.Location = new System.Drawing.Point(170, 318);
            this.butCong.Name = "butCong";
            this.butCong.Size = new System.Drawing.Size(75, 23);
            this.butCong.TabIndex = 6;
            this.butCong.Text = "Cộng";
            this.butCong.UseVisualStyleBackColor = true;
            this.butCong.Click += new System.EventHandler(this.butCong_Click);
            // 
            // butTru
            // 
            this.butTru.Location = new System.Drawing.Point(311, 317);
            this.butTru.Name = "butTru";
            this.butTru.Size = new System.Drawing.Size(75, 24);
            this.butTru.TabIndex = 7;
            this.butTru.Text = "Trừ";
            this.butTru.UseVisualStyleBackColor = true;
            this.butTru.Click += new System.EventHandler(this.butTru_Click);
            // 
            // butCong1
            // 
            this.butCong1.Location = new System.Drawing.Point(471, 317);
            this.butCong1.Name = "butCong1";
            this.butCong1.Size = new System.Drawing.Size(96, 24);
            this.butCong1.TabIndex = 8;
            this.butCong1.Text = "Cộng 1 giây";
            this.butCong1.UseVisualStyleBackColor = true;
            this.butCong1.Click += new System.EventHandler(this.butCong1_Click);
            // 
            // butTru1
            // 
            this.butTru1.Location = new System.Drawing.Point(630, 317);
            this.butTru1.Name = "butTru1";
            this.butTru1.Size = new System.Drawing.Size(84, 24);
            this.butTru1.TabIndex = 9;
            this.butTru1.Text = "Trừ 1 giây";
            this.butTru1.UseVisualStyleBackColor = true;
            this.butTru1.Click += new System.EventHandler(this.butTru1_Click);
            // 
            // butNhap
            // 
            this.butNhap.Location = new System.Drawing.Point(44, 317);
            this.butNhap.Name = "butNhap";
            this.butNhap.Size = new System.Drawing.Size(75, 23);
            this.butNhap.TabIndex = 10;
            this.butNhap.Text = "Nhập";
            this.butNhap.UseVisualStyleBackColor = true;
            this.butNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hiện tại";
            // 
            // txtThoigian
            // 
            this.txtThoigian.Location = new System.Drawing.Point(570, 66);
            this.txtThoigian.Name = "txtThoigian";
            this.txtThoigian.Size = new System.Drawing.Size(100, 22);
            this.txtThoigian.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtThoigian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.butNhap);
            this.Controls.Add(this.butTru1);
            this.Controls.Add(this.butCong1);
            this.Controls.Add(this.butTru);
            this.Controls.Add(this.butCong);
            this.Controls.Add(this.txtKq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGiaynew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiay);
            this.Controls.Add(this.txtPhut);
            this.Controls.Add(this.txtGio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.TextBox txtGiay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGiaynew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKq;
        private System.Windows.Forms.Button butCong;
        private System.Windows.Forms.Button butTru;
        private System.Windows.Forms.Button butCong1;
        private System.Windows.Forms.Button butTru1;
        private System.Windows.Forms.Button butNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtThoigian;
    }
}

