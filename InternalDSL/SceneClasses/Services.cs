using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;

namespace InternalDSL.SceneClasses
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
        public LidarBuilder lidar()
        {
            return parent.lidar();
        }
        public ObserverBuilder observer()
        {
            return parent.observer();
        }
        public CoefficientBuilder coefficient()
        {
            return parent.coefficient();
        }
        public Scene end()
        {
            return parent.baseScene;
        }
    }
}
