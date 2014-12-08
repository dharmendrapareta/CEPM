using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEPMBL.Entities
{
    public class ResultDto<T>
    {
        //Require
        public string Result { get; set; }
        public T Records { get; set; }
        public bool Success { get; set; }

        //optional
        public Dictionary<string, object> ComboList { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public int TotalRecordCount { get; set; }
    }
}
