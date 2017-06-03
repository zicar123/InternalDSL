using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.SceneBaseModel
{
    public class Coefficient
    {
        public string CoefficientTitle { get; set; }
        public List<int> FrequencyValues { get; set; }
        public List<double> AbatementValues { get; set; }
        public Coefficient()
        {
            FrequencyValues = new List<int>();
            AbatementValues = new List<double>();
        }
    }
}
