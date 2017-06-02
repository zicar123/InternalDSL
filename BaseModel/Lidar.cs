using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseModel
{
    public class Lidar
    {
        public string LidarTitle { get; set; }
        public Point LidarCoordinates { get; set; }
        public List<int> LidarFrequencies { get; set; }
        public List<int> LidarPowers { get; set; }
        public Lidar()
        {
            LidarFrequencies = new List<int>();
            LidarPowers = new List<int>();
        }
    }
}
