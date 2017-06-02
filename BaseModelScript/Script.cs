using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;

namespace BaseModelScript
{
    public class Script
    {
        public Object BaseScene { get; set; }
        public List<Angle> Angles { get; set; }
        public Limitation Limitations { get; set; }

        public Script()
        {
            Angles = new List<Angle>();
            Limitations = new Limitation();
        }
    }
}
