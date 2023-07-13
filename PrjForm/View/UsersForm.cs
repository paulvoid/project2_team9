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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void UsersForm_Load(object sender, EventArgs e)
        {
            string jsonResult = UsersController.GetUsers();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
            // add values to columns
            dgv_TT.DataSource = dt;
        }

        
        // validate all
        private bool validateAll()
        {
            bool result = true;
            if (txt_id.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã nhân viên");
            }
            else if (txt_name.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập tên nhân viên");
            }
            else if (txt_per.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập quyền");
            }
            else if (txt_pro.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã dây chuyền");
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
                User user = new User();
                user.User_code = txt_id.Text;
                user.Full_name = txt_name.Text;
                user.Permission = txt_per.Text;
                user.Production_line = txt_pro.Text;
                user.Updated_by = txt_udtBY.Text;
                user.Updated_date = txt_udtDT.Text;
                string result = UsersController.InsertUsers(user);
                // if Success in result
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Thêm thành công");
                    UsersForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
        }
        private void dgv_TT_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_TT.SelectedRows)
            {
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_name.Text = row.Cells[1].Value.ToString();
                txt_per.Text = row.Cells[2].Value.ToString();
                txt_pro.Text = row.Cells[3].Value.ToString();
                txt_udtBY.Text = row.Cells[4].Value.ToString();
                txt_udtDT.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                User user = new User();
                user.User_code = txt_id.Text;
                user.Full_name = txt_name.Text;
                user.Permission = txt_per.Text;
                user.Production_line = txt_pro.Text;
                user.Updated_by = txt_udtBY.Text;
                user.Updated_date = txt_udtDT.Text;
                string result = UsersController.UpdateUsers(user);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Sửa thành công");
                    UsersForm_Load(sender, e);
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
                User user = new User();
                user.User_code = txt_id.Text;
                string result = UsersController.DeleteUsers(user);
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Xóa thành công");
                    UsersForm_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_name.Text = "";
            txt_per.Text = "";
            txt_pro.Text = "";
            txt_udtBY.Text = "";
            txt_udtDT.Text = "";
        }    
        

        
    }
}