using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class LidarBuilder : Services
    {
        private SceneBuilder parent;
        private string lidarTitle;
        private List<int> lidarFrequencies = new List<int>();
        private List<int> lidarPowers = new List<int>();
        
        public LidarBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public LidarBuilder title(string value)
        {
            this.lidarTitle = value;
            return this;
        }
        public LidarBuilder frequencies(params int[] values)
        {
            this.lidarFrequencies = values.ToList();
            return this;
        }
        public LidarBuilder powers(params int[] values)
        {
            this.lidarPowers = values.ToList();
            return this;
        }
    }
}
