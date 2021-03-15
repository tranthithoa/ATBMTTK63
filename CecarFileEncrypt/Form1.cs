using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CecarFileEncrypt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tbDuongDan.Text))
            {
                MessageBox.Show("Bạn phải chọn tệp tin cần mã hóa hoặc giải mã");
                return;
            }    
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin bạn yêu cầu");
                return;
            }
            CecarFileHelper ch = new CecarFileHelper();
            Random rd = new Random();
            ch.K = (byte)rd.Next(0, 255);
            byte[] tmp;
            if(rbMaHoa.Checked)
                tmp = ch.Encrypt(tbDuongDan.Text);
            else
                tmp = ch.Decrypt(tbDuongDan.Text);
            if (tmp == null)
            {
                MessageBox.Show("Tệp tin rỗng!");
                return;
            }    
            else
            {
                SaveFileDialog sd = new SaveFileDialog();
                String ext = Path.GetExtension(tbDuongDan.Text);
                sd.Filter = ext + " files (*" + ext + ") | " + ext;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, tmp);
                }    
            }    
        }
    }
}
