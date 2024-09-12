namespace Bai1_winform1
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
            this.label4 = new System.Windows.Forms.Label();
            this.txthoanhdo = new System.Windows.Forms.TextBox();
            this.txttungdo = new System.Windows.Forms.TextBox();
            this.txtcaodo = new System.Windows.Forms.TextBox();
            this.txtToado = new System.Windows.Forms.TextBox();
            this.btthucthi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoành Độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tung Độ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cao Độ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tọa Độ";
            // 
            // txthoanhdo
            // 
            this.txthoanhdo.Location = new System.Drawing.Point(323, 93);
            this.txthoanhdo.Name = "txthoanhdo";
            this.txthoanhdo.Size = new System.Drawing.Size(100, 22);
            this.txthoanhdo.TabIndex = 1;
            // 
            // txttungdo
            // 
            this.txttungdo.Location = new System.Drawing.Point(323, 140);
            this.txttungdo.Name = "txttungdo";
            this.txttungdo.Size = new System.Drawing.Size(100, 22);
            this.txttungdo.TabIndex = 1;
            // 
            // txtcaodo
            // 
            this.txtcaodo.Location = new System.Drawing.Point(323, 192);
            this.txtcaodo.Name = "txtcaodo";
            this.txtcaodo.Size = new System.Drawing.Size(100, 22);
            this.txtcaodo.TabIndex = 1;
            // 
            // txtToado
            // 
            this.txtToado.Location = new System.Drawing.Point(323, 238);
            this.txtToado.Name = "txtToado";
            this.txtToado.Size = new System.Drawing.Size(100, 22);
            this.txtToado.TabIndex = 1;
            // 
            // btthucthi
            // 
            this.btthucthi.Location = new System.Drawing.Point(212, 291);
            this.btthucthi.Name = "btthucthi";
            this.btthucthi.Size = new System.Drawing.Size(75, 23);
            this.btthucthi.TabIndex = 2;
            this.btthucthi.Text = "Result";
            this.btthucthi.UseVisualStyleBackColor = true;
            this.btthucthi.Click += new System.EventHandler(this.btthucthi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btthucthi);
            this.Controls.Add(this.txtToado);
            this.Controls.Add(this.txtcaodo);
            this.Controls.Add(this.txttungdo);
            this.Controls.Add(this.txthoanhdo);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthoanhdo;
        private System.Windows.Forms.TextBox txttungdo;
        private System.Windows.Forms.TextBox txtcaodo;
        private System.Windows.Forms.TextBox txtToado;
        private System.Windows.Forms.Button btthucthi;
    }
}

