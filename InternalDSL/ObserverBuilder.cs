using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InternalDSL
{
    public class ObserverBuilder
    {
        public string Title { get; set; }
        public Point Coordinates { get; set; }
        public List<int> Frequencies { get; set; }
    }
}
