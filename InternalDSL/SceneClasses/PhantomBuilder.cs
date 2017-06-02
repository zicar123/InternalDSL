using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL.SceneClasses
{
    public class PhantomBuilder : Services
    {
        private SceneBuilder parent;
        public PhantomBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public PhantomBuilder title(string value)
        {
            parent.baseScene.Phantoms.Last().PhantomTitle = value;
            return this;
        }
        public PhantomBuilder coordinates(params Point[] values)
        {
            parent.baseScene.Phantoms.Last().PhantomCoordinates = values.ToList();
            return this;
        }
        public PhantomBuilder diffuseReflection(int frequency, double albedoValue)
        {
            parent.baseScene.Phantoms.Last().PhantomFrequencies.Add(frequency);
            parent.baseScene.Phantoms.Last().PhantomAlbedo.Add(albedoValue);
            return this;
        }
    }
}
