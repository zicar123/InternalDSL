using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL.SceneClasses
{
    public class LidarBuilder : Services
    {
        private SceneBuilder parent;
        public LidarBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public LidarBuilder title(string value)
        {
            parent.baseScene.Lidars.Last().LidarTitle = value;
            return this;
        }
        public LidarBuilder properties(int frequency, int power)
        {
            parent.baseScene.Lidars.Last().LidarFrequencies.Add(frequency);
            parent.baseScene.Lidars.Last().LidarPowers.Add(power);
            return this;
        }
        public LidarBuilder coordinates(Point lidarCoordinates)
        {
            parent.baseScene.Lidars.Last().LidarCoordinates = lidarCoordinates;
            return this;
        }
    }
}
