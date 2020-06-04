using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateDataScript.Model
{
    public class TableStructureModel
    {
        public string TabName { get; set; }
        public string TabExplain { get; set; }
        public string FieldName { get; set; }
        public int DataLength { get; set; }
        public string FieldRemarks { get; set; }
        public string DataType { get; set; }
        public string Type { get; set; }
    }
}