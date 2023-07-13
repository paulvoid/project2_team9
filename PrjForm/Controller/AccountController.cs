using PrjForm.Model;
using PrjForm.PlaningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Controller
{
    internal class AccountController
    {
        // crud
        public static string GetAccount()
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.getAccount();
            return result;
        }
        public static string InsertAccount(Account account)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.insertAccount(account.Username, account.Password, account.User_code);
            return result;
        }
        public static string UpdateAccount(Account account)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.updateAccount(account.Username, account.Password, account.User_code);
            return result;
        }
        public static string DeleteAccount(Account account)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.deleteAccount(account.User_code);
            return result;
        }
    }
}