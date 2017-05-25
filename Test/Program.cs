using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternalDSL;
using System.Drawing;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            InternalDSL.SceneBuilder scene = new InternalDSL.SceneBuilder();
            scene
                .polygon()
                    .title("Полигон")
                    .coordinates(new Point(10, 20), new Point(20, 30), new Point(50, 20))
                .phantom()
                    .title("Фантом")
                    .coordinates(new Point(10, 20), new Point(50, 30))
                    .frequencies(10, 20, 40)
                .phantom()
                    .title("Фантом_1")
                    .coordinates(new Point(10, 20), new Point(50, 30))
                    .frequencies(10, 20, 40)
                .coefficient()
                    .title("Коэффициент")
                    .frequencies(10, 20, 40);

            foreach (PhantomBuilder item in scene.PhantomsBuilders)
            {
                Console.WriteLine(item.getTitle);   
            }
            Console.ReadKey();
        }
    }
}
