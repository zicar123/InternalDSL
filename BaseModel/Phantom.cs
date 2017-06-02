using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BaseModel
{
    public class Phantom
    {
        public string PhantomTitle { get; set; }
        public List<Point> PhantomCoordinates { get; set; }
        public List<int> PhantomFrequencies { get; set; }
        public List<double> PhantomAlbedo { get; set; }
        public Phantom()
        {
            PhantomCoordinates = new List<Point>();
            PhantomFrequencies = new List<int>();
            PhantomAlbedo = new List<double>();
        }
    }
}
