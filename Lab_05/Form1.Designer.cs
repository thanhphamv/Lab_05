namespace Lab_05
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
            this.grbsv = new System.Windows.Forms.GroupBox();
            this.bttxoa = new System.Windows.Forms.Button();
            this.bttthem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.chkchuyennganh = new System.Windows.Forms.CheckBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.picturesv = new System.Windows.Forms.PictureBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bttaddpicture = new System.Windows.Forms.Button();
            this.grbsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(248, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Sinh Viên";
            // 
            // grbsv
            // 
            this.grbsv.Controls.Add(this.bttaddpicture);
            this.grbsv.Controls.Add(this.cbbkhoa);
            this.grbsv.Controls.Add(this.picturesv);
            this.grbsv.Controls.Add(this.txtdtb);
            this.grbsv.Controls.Add(this.txthoten);
            this.grbsv.Controls.Add(this.txtmssv);
            this.grbsv.Controls.Add(this.bttxoa);
            this.grbsv.Controls.Add(this.bttthem);
            this.grbsv.Controls.Add(this.label6);
            this.grbsv.Controls.Add(this.label5);
            this.grbsv.Controls.Add(this.label4);
            this.grbsv.Controls.Add(this.label3);
            this.grbsv.Controls.Add(this.label2);
            this.grbsv.Location = new System.Drawing.Point(12, 81);
            this.grbsv.Name = "grbsv";
            this.grbsv.Size = new System.Drawing.Size(236, 346);
            this.grbsv.TabIndex = 1;
            this.grbsv.TabStop = false;
            this.grbsv.Text = "Thông Tin Sinh Viên";
            // 
            // bttxoa
            // 
            this.bttxoa.Location = new System.Drawing.Point(155, 317);
            this.bttxoa.Name = "bttxoa";
            this.bttxoa.Size = new System.Drawing.Size(75, 23);
            this.bttxoa.TabIndex = 1;
            this.bttxoa.Text = "Delete";
            this.bttxoa.UseVisualStyleBackColor = true;
            this.bttxoa.Click += new System.EventHandler(this.bttxoa_Click);
            // 
            // bttthem
            // 
            this.bttthem.Location = new System.Drawing.Point(57, 317);
            this.bttthem.Name = "bttthem";
            this.bttthem.Size = new System.Drawing.Size(75, 23);
            this.bttthem.TabIndex = 1;
            this.bttthem.Text = "Add/Update";
            this.bttthem.UseVisualStyleBackColor = true;
            this.bttthem.Click += new System.EventHandler(this.bttthem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ảnh Đại Diện";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm Trung Bình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // dgvsv
            // 
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.ten,
            this.khoa,
            this.dtb,
            this.chuyennganh});
            this.dgvsv.Location = new System.Drawing.Point(254, 81);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(679, 357);
            this.dgvsv.TabIndex = 2;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsv_CellClick);
            // 
            // chkchuyennganh
            // 
            this.chkchuyennganh.AutoSize = true;
            this.chkchuyennganh.Location = new System.Drawing.Point(602, 55);
            this.chkchuyennganh.Name = "chkchuyennganh";
            this.chkchuyennganh.Size = new System.Drawing.Size(166, 20);
            this.chkchuyennganh.TabIndex = 3;
            this.chkchuyennganh.Text = "Chưa ĐK chuyên ngành";
            this.chkchuyennganh.UseVisualStyleBackColor = true;
            this.chkchuyennganh.CheckedChanged += new System.EventHandler(this.chkchuyennganh_CheckedChanged);
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(97, 34);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(133, 22);
            this.txtmssv.TabIndex = 2;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(97, 73);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(133, 22);
            this.txthoten.TabIndex = 2;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(117, 146);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(113, 22);
            this.txtdtb.TabIndex = 2;
            // 
            // picturesv
            // 
            this.picturesv.Location = new System.Drawing.Point(46, 202);
            this.picturesv.Name = "picturesv";
            this.picturesv.Size = new System.Drawing.Size(165, 109);
            this.picturesv.TabIndex = 3;
            this.picturesv.TabStop = false;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(97, 116);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(121, 24);
            this.cbbkhoa.TabIndex = 4;
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.MinimumWidth = 6;
            this.mssv.Name = "mssv";
            this.mssv.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "Họ Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // dtb
            // 
            this.dtb.HeaderText = "DTB";
            this.dtb.MinimumWidth = 6;
            this.dtb.Name = "dtb";
            this.dtb.Width = 125;
            // 
            // chuyennganh
            // 
            this.chuyennganh.HeaderText = "Chuyên Ngành";
            this.chuyennganh.MinimumWidth = 6;
            this.chuyennganh.Name = "chuyennganh";
            this.chuyennganh.Width = 125;
            // 
            // bttaddpicture
            // 
            this.bttaddpicture.Location = new System.Drawing.Point(196, 179);
            this.bttaddpicture.Name = "bttaddpicture";
            this.bttaddpicture.Size = new System.Drawing.Size(34, 25);
            this.bttaddpicture.TabIndex = 5;
            this.bttaddpicture.Text = "...";
            this.bttaddpicture.UseVisualStyleBackColor = true;
            this.bttaddpicture.Click += new System.EventHandler(this.bttaddpicture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.chkchuyennganh);
            this.Controls.Add(this.dgvsv);
            this.Controls.Add(this.grbsv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbsv.ResumeLayout(false);
            this.grbsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbsv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.CheckBox chkchuyennganh;
        private System.Windows.Forms.Button bttxoa;
        private System.Windows.Forms.Button bttthem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picturesv;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.Button bttaddpicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyennganh;
    }
}

