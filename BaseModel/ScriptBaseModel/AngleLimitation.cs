using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.ScriptBaseModel
{
    public class AngleLimitation
    {
        public string angleTitle { get; set; }
        public List<string> angleLimitationRange { get; set; }

        public AngleLimitation()
        {
            angleLimitationRange = new List<string>();
        }
    }
}
