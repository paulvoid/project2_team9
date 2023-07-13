using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Model
{
    internal class MasterData
    {
        // item machine process_code width height scrap updated_by updated_date
        private string item;
        private string machine;
        private string process_code;
        private string width;
        private string height;
        private string scrap;
        private string updated_by;
        private string updated_date;

        public string Item { get => item; set => item = value; }
        public string Machine { get => machine; set => machine = value; }
        public string Process_code { get => process_code; set => process_code = value; }
        public string Width { get => width; set => width = value; }
        public string Height { get => height; set => height = value; }
        public string Scrap { get => scrap; set => scrap = value; }
        public string Updated_by { get => updated_by; set => updated_by = value; }
        public string Updated_date { get => updated_date; set => updated_date = value; }
    }
}
