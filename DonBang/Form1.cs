using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonBang
{
    public partial class Form1 : Form
    {
        DonBangHelper dh = new DonBangHelper();
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            tbDuLieuDaMaHoa.Text = dh.MaHoa(tbDuLieuCanMaHoa.Text);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            tbDuLieuDaGiaiMa.Text = dh.GiaiMa(tbDuLieuDaMaHoa.Text);
        }
    }
}
