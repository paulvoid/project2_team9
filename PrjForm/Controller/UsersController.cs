using PrjForm.Model;
using PrjForm.PlaningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Controller
{
    internal class UsersController
    {
        // crud PlaningService
        public static string GetUsers()
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.getUsers();
            return result;
        }
        public static string InsertUsers(User user)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.insertUsers(user.User_code, user.Full_name, user.Permission, user.Production_line, user.Updated_by, user.Updated_date);
            return result;
        }
        public static string UpdateUsers(User user)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.updateUsers(user.User_code, user.Full_name, user.Permission, user.Production_line, user.Updated_by, user.Updated_date);
            return result;
        }
        public static string DeleteUsers(User user)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.deleteUsers(user.User_code);
            return result;
        }
        
    }
}