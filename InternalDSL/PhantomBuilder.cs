using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class PhantomBuilder : Services
    {
        private SceneBuilder parent;
        private string phantomTitle;
        private List<Point> phantomCoordinates = new List<Point>();
        private List<int> phantomFrequencies = new List<int>();

        public PhantomBuilder(SceneBuilder parent) : base(parent)
        {
            this.parent = parent;
        }
        public PhantomBuilder title(string value)
        {
            this.phantomTitle = value;
            return this;
        }
        public PhantomBuilder coordinates(params Point[] values)
        {
            this.phantomCoordinates = values.ToList();
            return this;
        }
        public PhantomBuilder frequencies(params int[] values)
        {
            this.phantomFrequencies = values.ToList();
            return this;
        }
        #region Output
        public string getTitle
        {
            get
            {
                return phantomTitle;
            }
        }
        #endregion
    }
}
