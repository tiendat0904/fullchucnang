namespace TimKiemHanghoa
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mah = new System.Windows.Forms.TextBox();
            this.txt_tenh = new System.Windows.Forms.TextBox();
            this.cbb_chatlieu = new System.Windows.Forms.ComboBox();
            this.txt_dgianhap = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_timkiem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.txt_dongiaban = new System.Windows.Forms.TextBox();
            this.txt_timkiemmah = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_xuat = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(172, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 37);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Tìm Kiếm Hàng Hóa";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Hàng :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_dongiaban);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.txt_dgianhap);
            this.groupBox1.Controls.Add(this.cbb_chatlieu);
            this.groupBox1.Controls.Add(this.txt_tenh);
            this.groupBox1.Controls.Add(this.txt_mah);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đơn giá bán :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(465, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chất Liệu:";
            // 
            // txt_mah
            // 
            this.txt_mah.Location = new System.Drawing.Point(128, 28);
            this.txt_mah.Name = "txt_mah";
            this.txt_mah.Size = new System.Drawing.Size(174, 22);
            this.txt_mah.TabIndex = 5;
            // 
            // txt_tenh
            // 
            this.txt_tenh.Location = new System.Drawing.Point(539, 21);
            this.txt_tenh.Name = "txt_tenh";
            this.txt_tenh.Size = new System.Drawing.Size(148, 22);
            this.txt_tenh.TabIndex = 6;
            // 
            // cbb_chatlieu
            // 
            this.cbb_chatlieu.FormattingEnabled = true;
            this.cbb_chatlieu.Location = new System.Drawing.Point(539, 57);
            this.cbb_chatlieu.Name = "cbb_chatlieu";
            this.cbb_chatlieu.Size = new System.Drawing.Size(148, 24);
            this.cbb_chatlieu.TabIndex = 7;
            // 
            // txt_dgianhap
            // 
            this.txt_dgianhap.Location = new System.Drawing.Point(128, 58);
            this.txt_dgianhap.Name = "txt_dgianhap";
            this.txt_dgianhap.Size = new System.Drawing.Size(174, 22);
            this.txt_dgianhap.TabIndex = 8;
            this.txt_dgianhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dgianhap_KeyPress);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(539, 101);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(148, 22);
            this.txt_soluong.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Đơn Giá Nhập :";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Số lượng :";
            // 
            // bt_timkiem
            // 
            this.bt_timkiem.Location = new System.Drawing.Point(35, 405);
            this.bt_timkiem.Name = "bt_timkiem";
            this.bt_timkiem.Size = new System.Drawing.Size(75, 23);
            this.bt_timkiem.TabIndex = 13;
            this.bt_timkiem.Text = "Tìm kiếm";
            this.bt_timkiem.UseVisualStyleBackColor = true;
            this.bt_timkiem.Click += new System.EventHandler(this.Bt_timkiem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(743, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(333, 405);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 15;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.Bt_them_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(446, 405);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 16;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.Bt_sua_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(563, 405);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 17;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.Bt_xoa_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(680, 405);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 18;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.Bt_thoat_Click);
            // 
            // txt_dongiaban
            // 
            this.txt_dongiaban.Location = new System.Drawing.Point(128, 90);
            this.txt_dongiaban.Name = "txt_dongiaban";
            this.txt_dongiaban.Size = new System.Drawing.Size(174, 22);
            this.txt_dongiaban.TabIndex = 12;
            this.txt_dongiaban.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_dongiaban_KeyPress);
            // 
            // txt_timkiemmah
            // 
            this.txt_timkiemmah.Location = new System.Drawing.Point(223, 406);
            this.txt_timkiemmah.Name = "txt_timkiemmah";
            this.txt_timkiemmah.Size = new System.Drawing.Size(80, 22);
            this.txt_timkiemmah.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(128, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mã Hàng :";
            // 
            // bt_xuat
            // 
            this.bt_xuat.Location = new System.Drawing.Point(661, 45);
            this.bt_xuat.Name = "bt_xuat";
            this.bt_xuat.Size = new System.Drawing.Size(94, 23);
            this.bt_xuat.TabIndex = 19;
            this.bt_xuat.Text = "Xuất excel";
            this.bt_xuat.UseVisualStyleBackColor = true;
            this.bt_xuat.Click += new System.EventHandler(this.Bt_xuat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_xuat);
            this.Controls.Add(this.txt_timkiemmah);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_timkiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_dgianhap;
        private System.Windows.Forms.ComboBox cbb_chatlieu;
        private System.Windows.Forms.TextBox txt_tenh;
        private System.Windows.Forms.TextBox txt_mah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_timkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.TextBox txt_dongiaban;
        private System.Windows.Forms.TextBox txt_timkiemmah;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_xuat;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

