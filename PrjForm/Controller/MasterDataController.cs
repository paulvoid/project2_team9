using PrjForm.Model;
using PrjForm.PlaningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Controller
{
    internal class MasterDataController
    {
        public static string GetMasterData()
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.getMasterData();
            return result;
        }
        public static string InsertMasterData(MasterData masterData)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.insertMasterData(masterData.Item, masterData.Machine, masterData.Process_code, masterData.Width, masterData.Height, masterData.Scrap, masterData.Updated_by, masterData.Updated_date);
            return result;
        }
        public static string UpdateMasterData(MasterData masterData)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.updateMasterData(masterData.Item, masterData.Machine, masterData.Process_code, masterData.Width, masterData.Height, masterData.Scrap, masterData.Updated_by, masterData.Updated_date);
            return result;
        }
        public static string DeleteMasterData(MasterData masterData)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.deleteMasterData(masterData.Item);
            return result;
        }

    }
}