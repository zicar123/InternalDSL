using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using InternalDSL.SceneClasses;
using BaseModel;
using BaseModel.SceneBaseModel;

namespace InternalDSL
{
    public class SceneBuilder
    {
        public Scene baseScene;
        public SceneBuilder()
        {
            baseScene = new Scene();
        }

        public PolygonBuilder polygon()
        {
            baseScene.Polygons.Add(new Polygon());
            return new PolygonBuilder(this);
        }
        public PhantomBuilder phantom()
        {
            baseScene.Phantoms.Add(new Phantom());
            return new PhantomBuilder(this);
        }
        public LidarBuilder lidar()
        {
            baseScene.Lidars.Add(new Lidar());
            return new LidarBuilder(this);
        }
        public ObserverBuilder observer()
        {
            baseScene.Observers.Add(new Observer());
            return new ObserverBuilder(this);
        }
        public CoefficientBuilder coefficient()
        {
            baseScene.Coefficients.Add(new Coefficient());
            return new CoefficientBuilder(this);
        }
        public Scene end()
        {
            return baseScene;
        }
        public static SceneBuilder scene()
        {
            return new SceneBuilder();
        }
    }
}
