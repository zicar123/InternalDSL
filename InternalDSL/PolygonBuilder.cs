using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class PolygonBuilder : Services
    {
        private SceneBuilder parent;
        private string polygonTitle;
        private List<Point> polygonCoordinates = new List<Point>();

        public PolygonBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public PolygonBuilder title(string value)
        {
            this.polygonTitle = value;
            return this;
        }
        public PolygonBuilder coordinates(params Point[] values)
        {
            this.polygonCoordinates = values.ToList();
            return this;
        }
        #region Output
        public string getTitle
        {
            get
            {
                return polygonTitle;
            }
        }
        #endregion
    }
}
