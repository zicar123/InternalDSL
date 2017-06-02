using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModelScript
{
    public class Angle
    {
        public string angleTitle { get; set; }
        public Dictionary<string, int> angleRange;
        public Angle()
        {
            angleRange = new Dictionary<string, int>() { { "angleFrom", 0 }, { "angleTo", 0 }, { "step", 0 } };
        }
    }
}
