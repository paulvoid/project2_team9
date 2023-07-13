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
    public partial class MasterDataForm : Form
    {
        public MasterDataForm()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void MasterDataForm_Load(object sender, EventArgs e)
        {
            string jsonResult = MasterDataController.GetMasterData();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
            dgv_TT.DataSource = dt;
        }

        private void dgv_TT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TT.SelectedRows.Count > 0)
            {
                //txt_item
                txt_item.Text = dgv_TT.SelectedRows[0].Cells[0].Value.ToString();
                txt_mch.Text = dgv_TT.SelectedRows[0].Cells[1].Value.ToString();
                txt_procd.Text = dgv_TT.SelectedRows[0].Cells[2].Value.ToString();
                txt_W.Text = dgv_TT.SelectedRows[0].Cells[3].Value.ToString();
                txt_H.Text = dgv_TT.SelectedRows[0].Cells[4].Value.ToString();
                txt_SC.Text = dgv_TT.SelectedRows[0].Cells[5].Value.ToString();
                txt_udtBY.Text = dgv_TT.SelectedRows[0].Cells[6].Value.ToString();
                txt_udtDT.Text = dgv_TT.SelectedRows[0].Cells[7].Value.ToString();
            }

        }
        private bool validateAll()
        {
            bool result = true;
            if (txt_item.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã sản phẩm");
            }
            else if (txt_mch.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập tên sản phẩm");
            }
            else if (txt_procd.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã quy trình");
            }
            else if (txt_W.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập chiều rộng");
            }
            else if (txt_H.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập chiều cao");
            }
            else if (txt_SC.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập số lượng");
            }
            else if (txt_udtBY.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập người cập nhật");
            }
            else if (txt_udtDT.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập ngày cập nhật");
            }
            return result;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                MasterData masterData = new MasterData();
                masterData.Item = txt_item.Text;
                masterData.Machine = txt_mch.Text;
                masterData.Process_code = txt_procd.Text;
                masterData.Width = txt_W.Text;
                masterData.Height = txt_H.Text;
                masterData.Scrap = txt_SC.Text;
                masterData.Updated_by = txt_udtBY.Text;
                masterData.Updated_date = txt_udtDT.Text;
                string result = MasterDataController.InsertMasterData(masterData);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Thêm thành công");
                    MasterDataForm_Load(sender, e);
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
                MasterData masterData = new MasterData();
                masterData.Item = txt_item.Text;
                masterData.Machine = txt_mch.Text;
                masterData.Process_code = txt_procd.Text;
                masterData.Width = txt_W.Text;
                masterData.Height = txt_H.Text;
                masterData.Scrap = txt_SC.Text;
                masterData.Updated_by = txt_udtBY.Text;
                masterData.Updated_date = txt_udtDT.Text;
                string result = MasterDataController.UpdateMasterData(masterData);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Cập nhật thành công");
                    MasterDataForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                MasterData masterData = new MasterData();
                masterData.Item = txt_item.Text;
                masterData.Machine = txt_mch.Text;
                masterData.Process_code = txt_procd.Text;
                masterData.Width = txt_W.Text;
                masterData.Height = txt_H.Text;
                masterData.Scrap = txt_SC.Text;
                masterData.Updated_by = txt_udtBY.Text;
                masterData.Updated_date = txt_udtDT.Text;
                string result = MasterDataController.DeleteMasterData(masterData);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Xóa thành công");
                    MasterDataForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_item.Text = "";
            txt_mch.Text = "";
            txt_procd.Text = "";
            txt_W.Text = "";
            txt_H.Text = "";
            txt_SC.Text = "";
            txt_udtBY.Text = "";
            txt_udtDT.Text = "";
        }
    }
}
  