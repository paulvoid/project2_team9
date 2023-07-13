using Newtonsoft.Json;
using PrjForm.Controller;
using PrjForm.Model;
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
    public partial class MasterProcessForm : Form
    {
        public MasterProcessForm()
        {
            InitializeComponent();
        }

        private void MasterProcessForm_Load(object sender, EventArgs e)
        {
            string jsonResult = MasterProcessController.GetMasterProcess();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
            // add values to columns
            dgv_TT.DataSource = dt;
        }

        private void dgv_TT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TT.SelectedRows.Count > 0)
            {
                txt_procd.Text = dgv_TT.SelectedRows[0].Cells[0].Value.ToString();
                txt_pronme.Text = dgv_TT.SelectedRows[0].Cells[1].Value.ToString();
                txt_prostt.Text = dgv_TT.SelectedRows[0].Cells[2].Value.ToString();
              
            }
        }

        private bool validateAll()
        {
            bool result = true;
            if (txt_procd.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã quy trình");
            }
            else if (txt_pronme.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập tên quy trình");
            }
            else if (txt_prostt.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập trạng thái quy trình");
            }
            return result;
        }
        
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                MasterProcess masterprocess = new MasterProcess();
                masterprocess.Process_code = txt_procd.Text;
                masterprocess.Process_name = txt_pronme.Text;
                masterprocess.Process_status = txt_prostt.Text;
                string result = MasterProcessController.InsertMasterProcess(masterprocess);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Thêm thành công");
                    MasterProcessForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                MasterProcess masterprocess = new MasterProcess();
                masterprocess.Process_code = txt_procd.Text;
                masterprocess.Process_name = txt_pronme.Text;
                masterprocess.Process_status = txt_prostt.Text;
                string result = MasterProcessController.UpdateMasterProcess(masterprocess);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Sửa thành công");
                    MasterProcessForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                MasterProcess masterprocess = new MasterProcess();
                masterprocess.Process_code = txt_procd.Text;
                masterprocess.Process_name = txt_pronme.Text;
                masterprocess.Process_status = txt_prostt.Text;
                string result = MasterProcessController.DeleteMasterProcess(masterprocess);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Xóa thành công");
                    MasterProcessForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_procd.Text = "";
            txt_pronme.Text = "";
            txt_prostt.Text = "";
        }
        
        
    }
}

