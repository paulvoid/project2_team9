using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2form.Views
{
    public partial class PlanningManagement : Form
    {
        public PlanningManagement()
        {
            InitializeComponent();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Account a = new Account();
            a.Show();*/
        }

        private void masterDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* master_data a = new master_data();
            a.Show();*/
        }

        private void masterProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* master_data a = new master_data();
            a.Show();*/
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Users a = new Users();
            a.Show();*/
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
