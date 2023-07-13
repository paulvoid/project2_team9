using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Model
{
    internal class MasterProcess
    {
        //process_code process_name process_status
        private string process_code;
        private string process_name;
        private string process_status;
        

        public string Process_code { get => process_code; set => process_code = value; }
        public string Process_name { get => process_name; set => process_name = value; }
        public string Process_status { get => process_status; set => process_status = value; }
    }
}