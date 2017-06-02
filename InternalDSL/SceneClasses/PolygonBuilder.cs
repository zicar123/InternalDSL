using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL.SceneClasses
{
    public class PolygonBuilder : Services
    {
        private SceneBuilder parent;
        public PolygonBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public PolygonBuilder title(string value)
        {
            parent.baseScene.Polygons.Last().PolygonTitle = value;
            return this;
        }
        public PolygonBuilder coordinates(params Point[] values)
        {
            parent.baseScene.Polygons.Last().PolygonCoordinates = values.ToList();
            return this;
        }
    }
}
