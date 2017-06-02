using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL.SceneClasses
{
    public class ObserverBuilder : Services
    {
        private SceneBuilder parent;
        public ObserverBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public ObserverBuilder title(string value)
        {
            parent.baseScene.Observers.Last().ObserverTitle = value;
            return this;
        }
        public ObserverBuilder frequencies(params int[] values)
        {
            parent.baseScene.Observers.Last().ObserverFrequencies = values.ToList();
            return this;
        }
        public ObserverBuilder coordinates(Point observerCoordinates)
        {
            parent.baseScene.Observers.Last().ObserverCoordinates = observerCoordinates;
            return this;
        }
    }
}
