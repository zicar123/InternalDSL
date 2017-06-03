using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BaseModel.SceneBaseModel;

namespace BaseModel
{
    public class Scene
    {
        public List<Phantom> Phantoms { get; set; }
        public List<Lidar> Lidars { get; set; }
        public List<Observer> Observers { get; set; }
        public List<Polygon> Polygons { get; set; }
        public List<Coefficient> Coefficients { get; set; }

        public Scene()
        {
            Phantoms = new List<Phantom>();
            Lidars = new List<Lidar>();
            Observers = new List<Observer>();
            Polygons = new List<Polygon>();
            Coefficients = new List<Coefficient>();
        }
    }
}
