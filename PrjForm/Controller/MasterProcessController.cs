using PrjForm.Model;
using PrjForm.PlaningService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Controller
{
    internal class MasterProcessController
    {
        public static string GetMasterProcess()
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.getMasterProcess();
            return result;
        }
        public static string InsertMasterProcess(MasterProcess masterProcess)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.insertMasterProcess(masterProcess.Process_code, masterProcess.Process_name, masterProcess.Process_status);
            return result;
        }
        public static string UpdateMasterProcess(MasterProcess masterProcess)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.updateMasterProcess(masterProcess.Process_code, masterProcess.Process_name, masterProcess.Process_status);
            return result;
        }
        public static string DeleteMasterProcess(MasterProcess masterProcess)
        {
            string result = "";
            PlanningWSSoapClient ws = new PlanningWSSoapClient();
            result = ws.deleteMasterProcess(masterProcess.Process_code);
            return result;
        }
    }
}