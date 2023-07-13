using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjForm.Model
{
    internal class User
    {
        // user_code full_name permission production_line updated_by updated_date
        private string user_code;
        private string full_name;
        private string permission;
        private string production_line;
        private string updated_by;
        private string updated_date;

        public string User_code { get => user_code; set => user_code = value; }
        public string Full_name { get => full_name; set => full_name = value; }
        public string Permission { get => permission; set => permission = value; }
        public string Production_line { get => production_line; set => production_line = value; }
        public string Updated_by { get => updated_by; set => updated_by = value; }
        public string Updated_date { get => updated_date; set => updated_date = value; }

        
    }
}