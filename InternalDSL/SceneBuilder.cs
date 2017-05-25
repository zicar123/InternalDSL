using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class SceneBuilder
    {
        public List<PhantomBuilder> PhantomsBuilders { get; set; }
        public List<LidarBuilder> LidarsBuilders { get; set; }
        public List<ObserverBuilder> ObserversBuilders { get; set; }
        public List<PolygonBuilder> PolygonsBuilders { get; set; }
        public List<CoefficientBuilder> CoefficientsBuilders { get; set; }

        public SceneBuilder()
        {
            PhantomsBuilders = new List<PhantomBuilder>();
            LidarsBuilders = new List<LidarBuilder>();
            ObserversBuilders = new List<ObserverBuilder>();
            PolygonsBuilders = new List<PolygonBuilder>();
            CoefficientsBuilders = new List<CoefficientBuilder>();
        }

        public PolygonBuilder polygon()
        {
            PolygonBuilder builder = new PolygonBuilder(this);
            PolygonsBuilders.Add(builder);
            return builder;
        }
        public PhantomBuilder phantom()
        {
            PhantomBuilder builder = new PhantomBuilder(this);
            PhantomsBuilders.Add(builder);
            return builder;
        }
        public LidarBuilder lidar()
        {
            LidarBuilder builder = new LidarBuilder(this);
            LidarsBuilders.Add(builder);
            return builder;
        }
        public CoefficientBuilder coefficient()
        {
            CoefficientBuilder builder = new CoefficientBuilder(this);
            CoefficientsBuilders.Add(builder);
            return builder;
        }
        public static SceneBuilder scene()
        {
            return new SceneBuilder();
        }
    }
}
