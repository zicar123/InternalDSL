using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalDSL
{
    public class Services
    {
        private SceneBuilder parent;
        public Services(SceneBuilder parent)
        {
            this.parent = parent;
        }
        public PolygonBuilder polygon()
        {
            return parent.polygon();
        }
        public PhantomBuilder phantom()
        {
            return parent.phantom();
        }
        public CoefficientBuilder coefficient()
        {
            return parent.coefficient();
        }
        public LidarBuilder lidar()
        {
            return parent.lidar();
        }
    }
}
