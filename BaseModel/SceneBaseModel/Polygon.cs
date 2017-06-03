using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseModel.SceneBaseModel
{
    public class Polygon
    {
        public string PolygonTitle { get; set; }
        public List<Point> PolygonCoordinates { get; set; }
        public Polygon()
        {
            PolygonCoordinates = new List<Point>();
        }
    }
}
