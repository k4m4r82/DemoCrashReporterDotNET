namespace DemoCrashReporterDotNET
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
            this.btnPembagian = new System.Windows.Forms.Button();
            this.txtNilaiA = new System.Windows.Forms.TextBox();
            this.txtNilaiB = new System.Windows.Forms.TextBox();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.btnBukaFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNamaFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPembagian
            // 
            this.btnPembagian.Location = new System.Drawing.Point(108, 97);
            this.btnPembagian.Name = "btnPembagian";
            this.btnPembagian.Size = new System.Drawing.Size(75, 23);
            this.btnPembagian.TabIndex = 0;
            this.btnPembagian.Text = "Proses";
            this.btnPembagian.UseVisualStyleBackColor = true;
            this.btnPembagian.Click += new System.EventHandler(this.btnPembagian_Click);
            // 
            // txtNilaiA
            // 
            this.txtNilaiA.Location = new System.Drawing.Point(83, 19);
            this.txtNilaiA.Name = "txtNilaiA";
            this.txtNilaiA.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiA.TabIndex = 1;
            this.txtNilaiA.Text = "5";
            this.txtNilaiA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNilaiB
            // 
            this.txtNilaiB.Location = new System.Drawing.Point(83, 45);
            this.txtNilaiB.Name = "txtNilaiB";
            this.txtNilaiB.Size = new System.Drawing.Size(100, 20);
            this.txtNilaiB.TabIndex = 1;
            this.txtNilaiB.Text = "0";
            this.txtNilaiB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHasil
            // 
            this.txtHasil.Location = new System.Drawing.Point(83, 71);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(100, 20);
            this.txtHasil.TabIndex = 1;
            this.txtHasil.Text = "0";
            this.txtHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBukaFile
            // 
            this.btnBukaFile.Location = new System.Drawing.Point(164, 97);
            this.btnBukaFile.Name = "btnBukaFile";
            this.btnBukaFile.Size = new System.Drawing.Size(75, 23);
            this.btnBukaFile.TabIndex = 2;
            this.btnBukaFile.Text = "Proses";
            this.btnBukaFile.UseVisualStyleBackColor = true;
            this.btnBukaFile.Click += new System.EventHandler(this.btnBukaFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nilai A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nilai B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nilai A / B";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNilaiA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnPembagian);
            this.groupBox1.Controls.Add(this.txtNilaiB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtHasil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 131);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " [ DivideByZeroException ] ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNamaFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnBukaFile);
            this.groupBox2.Location = new System.Drawing.Point(216, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " [ FileNotFoundException ] ";
            // 
            // txtNamaFile
            // 
            this.txtNamaFile.Location = new System.Drawing.Point(68, 25);
            this.txtNamaFile.Name = "txtNamaFile";
            this.txtNamaFile.Size = new System.Drawing.Size(171, 20);
            this.txtNamaFile.TabIndex = 1;
            this.txtNamaFile.Text = "C:\\log.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nama File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 152);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo CrashReporter.NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPembagian;
        private System.Windows.Forms.TextBox txtNilaiA;
        private System.Windows.Forms.TextBox txtNilaiB;
        private System.Windows.Forms.TextBox txtHasil;
        private System.Windows.Forms.Button btnBukaFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNamaFile;
        private System.Windows.Forms.Label label6;
    }
}

