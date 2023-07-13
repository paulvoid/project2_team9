using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Ajax.Utilities;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace PrjWs
{
    /// <summary>
    /// Summary description for PlanningWS , bài của nhóm 9. NTS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class PlanningWS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=WINDOWS-11\SQLEXPRESS;Initial Catalog=Planning;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public string querySQL(string sql)
        {
            SqlConnection connection = GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            string json = JsonConvert.SerializeObject(dt);
            return json;
        }

        public string insertSQL(string sql)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Insert Success";
        }

        public string updateSQL(string sql)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Update Success";
        }

        public string deleteSQL(string sql)
        {
            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return "Delete Success";
        }

        // basic crud each table
        // users
        [WebMethod]
        public string getUsers()
        {
            string sql = "select * from users";
            return querySQL(sql);
        }

        [WebMethod]
        public string insertUsers(string user_code, string full_name, string permission, string production_line, string updated_by, string updated_date)
        {
            string sql = "insert into users values('" + user_code + "',N'" + full_name + "','" + permission + "','" + production_line + "','" + updated_by + "','" + updated_date + "')";
            return insertSQL(sql);
        }

        [WebMethod]
        public string updateUsers(string user_code, string full_name, string permission, string production_line, string updated_by, string updated_date)
        {
            string sql = "update users set full_name=N'" + full_name + "',permission='" + permission + "',production_line='" + production_line + "',updated_by='" + updated_by + "',updated_date='" + updated_date + "' where user_code='" + user_code + "'";
            return updateSQL(sql);
        }

        [WebMethod]
        public string deleteUsers(string user_code)
        {
            string sql = "delete from users where user_code='" + user_code + "'";
            return deleteSQL(sql);
        }

        // account
        [WebMethod]
        public string getAccount()
        {
            string sql = "select * from account";
            return querySQL(sql);
        }

        [WebMethod]
        public string insertAccount(string username, string pass, string user_code)
        {
            string sql = "insert into account values('" + username + "','" + pass + "','" + user_code + "')";
            return insertSQL(sql);
        }

        [WebMethod]
        public string updateAccount(string username, string pass, string user_code)
        {
            string sql = "update account set pass='" + pass + "',user_code='" + user_code + "' where username='" + username + "'";
            return updateSQL(sql);
        }

        [WebMethod]
        public string deleteAccount(string username)
        {
            string sql = "delete from account where username='" + username + "'";
            return deleteSQL(sql);
        }

        // master_data
        [WebMethod]
        public string getMasterData()
        {
            string sql = "select * from master_data";
            return querySQL(sql);
        }

        [WebMethod]
        public string insertMasterData(string item, string machine, string process_code, string width, string height, string scrap, string updated_by, string updated_date)
        {
            string sql = "insert into master_data values('" + item + "','" + machine + "','" + process_code + "','" + width + "','" + height + "','" + scrap + "','" + updated_by + "','" + updated_date + "')";
            return insertSQL(sql);
        }

        [WebMethod]
        public string updateMasterData(string item, string machine, string process_code, string width, string height, string scrap, string updated_by, string updated_date)
        {
            string sql = "update master_data set machine='" + machine + "',process_code='" + process_code + "',width='" + width + "',height='" + height + "',scrap='" + scrap + "',updated_by='" + updated_by + "',updated_date='" + updated_date + "' where item='" + item + "'";
            return updateSQL(sql);
        }

        [WebMethod]
        public string deleteMasterData(string item)
        {
            string sql = "delete from master_data where item='" + item + "'";
            return deleteSQL(sql);
        }

        // master_process
        [WebMethod]
        public string getMasterProcess()
        {
            string sql = "select * from master_process";
            return querySQL(sql);
        }

        [WebMethod]
        public string insertMasterProcess(string process_code, string process_name, string process_status)
        {
            string sql = "insert into master_process values('" + process_code + "',N'" + process_name + "','" + process_status + "')";
            return insertSQL(sql);
        }

        [WebMethod]
        public string updateMasterProcess(string process_code, string process_name, string process_status)
        {
            string sql = "update master_process set process_name=N'" + process_name + "',process_status='" + process_status + "' where process_code='" + process_code + "'";
            return updateSQL(sql);
        }

        [WebMethod]
        public string deleteMasterProcess(string process_code)
        {
            string sql = "delete from master_process where process_code='" + process_code + "'";
            return deleteSQL(sql);
        }
        // testing connect
        [WebMethod]
        public string TestConnect()
        {
            //testing database connect
            SqlConnection connection = GetConnection();
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                return "Connect Success";
            }
            else
            {
                return "Connect Fail";
            }
        }
        // return json
    }
}