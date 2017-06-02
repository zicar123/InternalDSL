using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL.SceneClasses
{
    public class CoefficientBuilder : Services
    {
        private SceneBuilder parent;
        public CoefficientBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public CoefficientBuilder title(string value)
        {
            parent.baseScene.Coefficients.Last().CoefficientTitle = value;
            return this;
        }
        public CoefficientBuilder abatement(int frequencyValue, double abatementValue)
        {
            parent.baseScene.Coefficients.Last().FrequencyValues.Add(frequencyValue);
            parent.baseScene.Coefficients.Last().AbatementValues.Add(abatementValue);
            return this;
        }
    }
}
