using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.ScriptBaseModel
{
    public class Limitation
    {
        public List<Object> LimitationsCollection { get; set; }
        public List<string> OperatorsCollection { get; set; }
        public Limitation()
        {
            LimitationsCollection = new List<Object>();
            OperatorsCollection = new List<string>();
        }
    }
}
