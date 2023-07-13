using Newtonsoft.Json;
using PrjForm.Controller;
using PrjForm.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace PrjForm
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            string jsonResult = AccountController.GetAccount();
            DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonResult);
            // add values to columns
            dgv_TT.DataSource = dt;
        }

        private void dgv_TT_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_TT.SelectedRows.Count > 0)
            {
                txt_id.Text = dgv_TT.SelectedRows[0].Cells[2].Value.ToString();
                txt_name.Text = dgv_TT.SelectedRows[0].Cells[0].Value.ToString();
                txt_pass.Text = dgv_TT.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private bool validateAll()
        {
            bool result = true;
            if (txt_id.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mã tài khoản");
            }
            else if (txt_name.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập tên tài khoản");
            }
            else if (txt_pass.Text == "")
            {
                result = false;
                MessageBox.Show("Hãy nhập mật khẩu");
            }
            return result;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateAll())
            {
                Account account = new Account();
                account.Username = txt_name.Text;
                account.Password = txt_pass.Text;
                account.User_code = txt_id.Text;
                string result = AccountController.InsertAccount(account);
                // if Success in result
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Thêm thành công");
                    AccountForm_Load(sender, e);
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
                Account account = new Account();
                account.Username = txt_name.Text;
                account.Password = txt_pass.Text;
                account.User_code = txt_id.Text;
                string result = AccountController.UpdateAccount(account);
                // if Success in result
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Sửa thành công");
                    AccountForm_Load(sender, e);
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
                Account account = new Account();
                account.Username = txt_name.Text;
                account.Password = txt_pass.Text;
                account.User_code = txt_id.Text;
                string result = AccountController.DeleteAccount(account);
                // if Success in result
                if (result.Contains("Success"))
                {
                    MessageBox.Show("Xóa thành công");
                    AccountForm_Load(sender, e);
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
            txt_pass.Text = "";
        }
    }
}