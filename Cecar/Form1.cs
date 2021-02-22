using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cecar
{
    public partial class Form1 : Form
    {
        CecarHelper cc = new CecarHelper(4);

        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            if(tbDuLieuCanMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cẫn mã hóa!");
                tbDuLieuCanMaHoa.Focus();
                return;
            }    
            else
            {
                tbDuLieuDaMaHoa.Text = cc.MaHoa(tbDuLieuCanMaHoa.Text);
            }    
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            if(tbDuLieuDaMaHoa.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập dữ liệu cần giải mã!");
                tbDuLieuDaMaHoa.Focus();
                return;
            } 
            else
            {
                tbDuLieuDaGiaiMa.Text = cc.GiaiMa(tbDuLieuDaMaHoa.Text);
            }    
        }
    }
}
