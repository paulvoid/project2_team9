using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjForm
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.Show();
        }


        private void btnAcc_Click(object sender, EventArgs e)
        {
            AccountForm frm = new AccountForm();
            frm.Show();
        }




        private void btnData_Click(object sender, EventArgs e)
        {
            MasterDataForm frm = new MasterDataForm();
            frm.Show();
        }



        private void btnPro_Click(object sender, EventArgs e)
        {
            MasterProcessForm frm = new MasterProcessForm();
            frm.Show();
        }

    }
}