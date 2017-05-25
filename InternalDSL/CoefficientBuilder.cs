using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class CoefficientBuilder : Services
    {
        private SceneBuilder parent;
        private string coefficientTitle;
        private List<int> frequencyValues = new List<int>();
        private List<float> abatementValues = new List<float>();

        public CoefficientBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public CoefficientBuilder title(string value)
        {
            this.coefficientTitle = value;
            return this;
        }
        public CoefficientBuilder frequencies(params int[] values)
        {
            this.frequencyValues = values.ToList();
            return this;
        }
        public CoefficientBuilder attenuation(List<float> values)
        {
            this.abatementValues = values;
            return this;
        }
        #region Output
        public string getTitle
        {
            get
            {
                return coefficientTitle;
            }
        }
        #endregion
    }
}
