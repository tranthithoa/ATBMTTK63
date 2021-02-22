
namespace CecarFileEncrypt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rbMaHoa = new System.Windows.Forms.RadioButton();
            this.rbGiaiMa = new System.Windows.Forms.RadioButton();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTienTrinh = new System.Windows.Forms.ProgressBar();
            this.btThucHien = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbMaHoa
            // 
            this.rbMaHoa.AutoSize = true;
            this.rbMaHoa.Location = new System.Drawing.Point(201, 21);
            this.rbMaHoa.Name = "rbMaHoa";
            this.rbMaHoa.Size = new System.Drawing.Size(61, 17);
            this.rbMaHoa.TabIndex = 0;
            this.rbMaHoa.TabStop = true;
            this.rbMaHoa.Text = "Mã hóa";
            this.rbMaHoa.UseVisualStyleBackColor = true;
            this.rbMaHoa.CheckedChanged += new System.EventHandler(this.rbMaHoa_CheckedChanged);
            // 
            // rbGiaiMa
            // 
            this.rbGiaiMa.AutoSize = true;
            this.rbGiaiMa.Location = new System.Drawing.Point(281, 22);
            this.rbGiaiMa.Name = "rbGiaiMa";
            this.rbGiaiMa.Size = new System.Drawing.Size(60, 17);
            this.rbGiaiMa.TabIndex = 1;
            this.rbGiaiMa.TabStop = true;
            this.rbGiaiMa.Text = "Giải mã";
            this.rbGiaiMa.UseVisualStyleBackColor = true;
            this.rbGiaiMa.CheckedChanged += new System.EventHandler(this.rbGiaiMa_CheckedChanged);
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(11, 66);
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(445, 20);
            this.tbDuongDan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn tệp tin cần thao tác";
            // 
            // pbTienTrinh
            // 
            this.pbTienTrinh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTienTrinh.Location = new System.Drawing.Point(0, 171);
            this.pbTienTrinh.Name = "pbTienTrinh";
            this.pbTienTrinh.Size = new System.Drawing.Size(555, 23);
            this.pbTienTrinh.TabIndex = 6;
            // 
            // btThucHien
            // 
            this.btThucHien.Image = global::CecarFileEncrypt.Properties.Resources.VideoIcon20;
            this.btThucHien.Location = new System.Drawing.Point(188, 102);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(167, 48);
            this.btThucHien.TabIndex = 5;
            this.btThucHien.Text = "   Thực hiện";
            this.btThucHien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // btTim
            // 
            this.btTim.Image = global::CecarFileEncrypt.Properties.Resources.SearchIcon20;
            this.btTim.Location = new System.Drawing.Point(462, 60);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 31);
            this.btTim.TabIndex = 4;
            this.btTim.Text = "   Tìm";
            this.btTim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 194);
            this.Controls.Add(this.pbTienTrinh);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.rbGiaiMa);
            this.Controls.Add(this.rbMaHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cecar File Encrypt - Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbMaHoa;
        private System.Windows.Forms.RadioButton rbGiaiMa;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.ProgressBar pbTienTrinh;
    }
}

