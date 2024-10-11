namespace LuongDinhHoang_Bai2
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
            panel1 = new Panel();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnxoanv = new Button();
            txtmanv = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnthemnv = new Button();
            txtlcbnv = new TextBox();
            txttennv = new TextBox();
            label3 = new Label();
            label1 = new Label();
            dt1 = new DataGridView();
            panel3 = new Panel();
            groupBox4 = new GroupBox();
            btnxoaql = new Button();
            txtmaql = new TextBox();
            label8 = new Label();
            groupBox3 = new GroupBox();
            btnthemql = new Button();
            txthoahong = new TextBox();
            txtlcbql = new TextBox();
            txtchucvu = new TextBox();
            txttenql = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dt2 = new DataGridView();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).BeginInit();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1550, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox2);
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(dt1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(1550, 393);
            panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnxoanv);
            groupBox2.Controls.Add(txtmanv);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(432, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 393);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Xóa nhân viên";
            // 
            // btnxoanv
            // 
            btnxoanv.Location = new Point(197, 99);
            btnxoanv.Name = "btnxoanv";
            btnxoanv.Size = new Size(94, 29);
            btnxoanv.TabIndex = 3;
            btnxoanv.Text = "Xóa NV";
            btnxoanv.UseVisualStyleBackColor = true;
            btnxoanv.Click += btnxoanv_Click;
            // 
            // txtmanv
            // 
            txtmanv.Location = new Point(197, 51);
            txtmanv.Name = "txtmanv";
            txtmanv.Size = new Size(162, 27);
            txtmanv.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 54);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnthemnv);
            groupBox1.Controls.Add(txtlcbnv);
            groupBox1.Controls.Add(txttennv);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(432, 393);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm nhân viên";
            // 
            // btnthemnv
            // 
            btnthemnv.Location = new Point(185, 154);
            btnthemnv.Name = "btnthemnv";
            btnthemnv.Size = new Size(94, 29);
            btnthemnv.TabIndex = 5;
            btnthemnv.Text = "Thêm NV";
            btnthemnv.UseVisualStyleBackColor = true;
            btnthemnv.Click += btnthemnv_Click;
            // 
            // txtlcbnv
            // 
            txtlcbnv.Location = new Point(185, 99);
            txtlcbnv.Name = "txtlcbnv";
            txtlcbnv.Size = new Size(181, 27);
            txtlcbnv.TabIndex = 4;
            // 
            // txttennv
            // 
            txttennv.Location = new Point(185, 51);
            txttennv.Name = "txttennv";
            txttennv.Size = new Size(181, 27);
            txttennv.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 99);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 2;
            label3.Text = "Lương cơ bản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 54);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên nhân viên";
            // 
            // dt1
            // 
            dt1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt1.Dock = DockStyle.Right;
            dt1.Location = new Point(863, 0);
            dt1.Name = "dt1";
            dt1.RowHeadersWidth = 51;
            dt1.Size = new Size(687, 393);
            dt1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox4);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(dt2);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(1550, 336);
            panel3.TabIndex = 2;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnxoaql);
            groupBox4.Controls.Add(txtmaql);
            groupBox4.Controls.Add(label8);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(432, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(431, 336);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Xóa quản lý";
            // 
            // btnxoaql
            // 
            btnxoaql.Location = new Point(197, 110);
            btnxoaql.Name = "btnxoaql";
            btnxoaql.Size = new Size(94, 29);
            btnxoaql.TabIndex = 5;
            btnxoaql.Text = "Xóa QL";
            btnxoaql.UseVisualStyleBackColor = true;
            btnxoaql.Click += btnxoaql_Click;
            // 
            // txtmaql
            // 
            txtmaql.Location = new Point(197, 57);
            txtmaql.Name = "txtmaql";
            txtmaql.Size = new Size(162, 27);
            txtmaql.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(55, 60);
            label8.Name = "label8";
            label8.Size = new Size(82, 20);
            label8.TabIndex = 3;
            label8.Text = "Mã quản lý";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnthemql);
            groupBox3.Controls.Add(txthoahong);
            groupBox3.Controls.Add(txtlcbql);
            groupBox3.Controls.Add(txtchucvu);
            groupBox3.Controls.Add(txttenql);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(432, 336);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thêm quản lý";
            // 
            // btnthemql
            // 
            btnthemql.Location = new Point(185, 273);
            btnthemql.Name = "btnthemql";
            btnthemql.Size = new Size(94, 29);
            btnthemql.TabIndex = 8;
            btnthemql.Text = "Thêm QL";
            btnthemql.UseVisualStyleBackColor = true;
            btnthemql.Click += btnthemql_Click;
            // 
            // txthoahong
            // 
            txthoahong.Location = new Point(185, 211);
            txthoahong.Name = "txthoahong";
            txthoahong.Size = new Size(172, 27);
            txthoahong.TabIndex = 7;
            // 
            // txtlcbql
            // 
            txtlcbql.Location = new Point(185, 169);
            txtlcbql.Name = "txtlcbql";
            txtlcbql.Size = new Size(172, 27);
            txtlcbql.TabIndex = 6;
            // 
            // txtchucvu
            // 
            txtchucvu.Location = new Point(185, 116);
            txtchucvu.Name = "txtchucvu";
            txtchucvu.Size = new Size(172, 27);
            txtchucvu.TabIndex = 5;
            // 
            // txttenql
            // 
            txttenql.Location = new Point(185, 66);
            txttenql.Name = "txttenql";
            txttenql.Size = new Size(172, 27);
            txttenql.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 69);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Tên quản lý";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 214);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 2;
            label7.Text = "Hoa hồng %";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 172);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 1;
            label6.Text = "Lương cơ bản";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 119);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 0;
            label5.Text = "Chức vụ";
            // 
            // dt2
            // 
            dt2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt2.Dock = DockStyle.Right;
            dt2.Location = new Point(863, 0);
            dt2.Name = "dt2";
            dt2.RowHeadersWidth = 51;
            dt2.Size = new Size(687, 336);
            dt2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 739);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Quản lý nhân sự 2024";
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt1).EndInit();
            panel3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dt2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox2;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dt1;
        private Panel panel3;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private DataGridView dt2;
        private TextBox txtmanv;
        private TextBox txtlcbnv;
        private TextBox txttennv;
        private TextBox txtmaql;
        private TextBox txthoahong;
        private TextBox txtlcbql;
        private TextBox txtchucvu;
        private TextBox txttenql;
        private Button btnxoanv;
        private Button btnthemnv;
        private Button btnxoaql;
        private Button btnthemql;
    }
}
