using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseModel.SceneBaseModel
{
    public class Observer
    {
        public string ObserverTitle { get; set; }
        public Point ObserverCoordinates { get; set; }
        public List<int> ObserverFrequencies { get; set; }
        public Observer()
        {
            ObserverFrequencies = new List<int>();
        }
    }
}
