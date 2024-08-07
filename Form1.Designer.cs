namespace CSharp_Tiendien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cbxKH = new ComboBox();
            label3 = new Label();
            txtDien = new TextBox();
            label4 = new Label();
            txtGia = new TextBox();
            label5 = new Label();
            txtTien = new TextBox();
            btnTinh = new Button();
            btnThoat = new Button();
            label6 = new Label();
            label7 = new Label();
            txtSomoi = new TextBox();
            txtSocu = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 28.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 38);
            label1.Name = "label1";
            label1.Size = new Size(615, 93);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TIỀN ĐIỆN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F);
            label2.Location = new Point(133, 189);
            label2.Name = "label2";
            label2.Size = new Size(206, 39);
            label2.TabIndex = 1;
            label2.Text = "Khách hàng :";
            // 
            // cbxKH
            // 
            cbxKH.Font = new Font("Tahoma", 12F);
            cbxKH.FormattingEnabled = true;
            cbxKH.Location = new Point(529, 189);
            cbxKH.Name = "cbxKH";
            cbxKH.Size = new Size(440, 47);
            cbxKH.TabIndex = 2;
            cbxKH.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F);
            label3.Location = new Point(133, 460);
            label3.Name = "label3";
            label3.Size = new Size(353, 39);
            label3.TabIndex = 3;
            label3.Text = "Số lượng điện tiêu thụ :";
            // 
            // txtDien
            // 
            txtDien.Font = new Font("Tahoma", 12F);
            txtDien.Location = new Point(529, 460);
            txtDien.Name = "txtDien";
            txtDien.Size = new Size(242, 46);
            txtDien.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F);
            label4.Location = new Point(133, 547);
            label4.Name = "label4";
            label4.Size = new Size(175, 39);
            label4.TabIndex = 3;
            label4.Text = "Giá thành :";
            label4.Click += label4_Click;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Tahoma", 12F);
            txtGia.Location = new Point(529, 544);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(242, 46);
            txtGia.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 12F);
            label5.Location = new Point(133, 638);
            label5.Name = "label5";
            label5.Size = new Size(191, 39);
            label5.TabIndex = 3;
            label5.Text = "Thành tiền :";
            label5.Click += label5_Click;
            // 
            // txtTien
            // 
            txtTien.Font = new Font("Tahoma", 12F);
            txtTien.Location = new Point(529, 635);
            txtTien.Name = "txtTien";
            txtTien.Size = new Size(242, 46);
            txtTien.TabIndex = 4;
            txtTien.TextChanged += txtTien_TextChanged;
            // 
            // btnTinh
            // 
            btnTinh.Font = new Font("Tahoma", 14F);
            btnTinh.Location = new Point(1071, 181);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(170, 57);
            btnTinh.TabIndex = 5;
            btnTinh.Text = "TÍNH";
            btnTinh.UseVisualStyleBackColor = true;
            btnTinh.Click += btnTinh_Click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Tahoma", 14F);
            btnThoat.Location = new Point(1071, 582);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(170, 57);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "THOÁT";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 12F);
            label6.Location = new Point(133, 282);
            label6.Name = "label6";
            label6.Size = new Size(166, 39);
            label6.TabIndex = 1;
            label6.Text = "Chỉ số cũ :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 12F);
            label7.Location = new Point(133, 365);
            label7.Name = "label7";
            label7.Size = new Size(185, 39);
            label7.TabIndex = 1;
            label7.Text = "Chỉ số mới :";
            // 
            // txtSomoi
            // 
            txtSomoi.Font = new Font("Tahoma", 12F);
            txtSomoi.Location = new Point(529, 365);
            txtSomoi.Name = "txtSomoi";
            txtSomoi.Size = new Size(242, 46);
            txtSomoi.TabIndex = 4;
            // 
            // txtSocu
            // 
            txtSocu.Font = new Font("Tahoma", 12F);
            txtSocu.Location = new Point(529, 282);
            txtSocu.Name = "txtSocu";
            txtSocu.Size = new Size(242, 46);
            txtSocu.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 742);
            Controls.Add(btnThoat);
            Controls.Add(btnTinh);
            Controls.Add(txtTien);
            Controls.Add(txtGia);
            Controls.Add(txtSomoi);
            Controls.Add(txtSocu);
            Controls.Add(txtDien);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbxKH);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tính tiền điện phải trả";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbxKH;
        private Label label3;
        private TextBox txtDien;
        private Label label4;
        private TextBox txtGia;
        private Label label5;
        private TextBox txtTien;
        private Button btnTinh;
        private Button btnThoat;
        private Label label6;
        private Label label7;
        private TextBox txtSomoi;
        private TextBox txtSocu;
    }
}
