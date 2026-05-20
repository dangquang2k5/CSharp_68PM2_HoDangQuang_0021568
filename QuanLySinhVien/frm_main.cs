using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }



        private void tstr_qlsv_Click(object sender, EventArgs e)
        {
            uc_qlsv uc_qlsv = new uc_qlsv();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uc_qlsv);
        }

        private void tstr_qllh_Click(object sender, EventArgs e)
        {
            uc_qllh uc_qllh = new uc_qllh();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(uc_qllh);
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }
    }
}
