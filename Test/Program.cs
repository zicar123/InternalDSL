using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternalDSL;
using System.Drawing;
using BaseModel;
using BaseModel.SceneBaseModel;
using BaseModel.ScriptBaseModel;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Scene scene = InternalDSL.SceneBuilder
            .scene()
                .polygon()
                    .title("Полігон")
                    .coordinates(SetValue.point(10, 20), SetValue.point(20, 30), SetValue.point(50, 20))
                .phantom()
                    .title("Фантом")
                    .coordinates(new Point(10, 20), new Point(50, 30))
                    .diffuseReflection(
                        SetValue.frequencyValue(10),
                        SetValue.albedoValue(0.4)
                    )
                    .diffuseReflection(20, 0.8)
                .phantom()
                    .title("Фантом_1")
                    .coordinates(new Point(10, 20), new Point(50, 30))
                    .diffuseReflection(40, 0.2)
                .coefficient()
                    .title("Коефіцієнт")
                    .abatement(10, 0.3)
                .lidar()
                    .title("Лідар")
                    .coordinates(SetValue.point(50, 50))
                    .properties(10, 100)
                    .properties(20, 200)
                .observer()
                    .title("Спостерігач")
                    .frequencies(10, 30, 40)
                .end();

            Script script = InternalDSL.ScriptBuilder
             .script()
               .scene(scene)
               .angles()
                   .angle()
                       .title("Кут")
                       .range(-90, 80, 5)
                    .angle()
                       .title("Кут_1")
                       .range(-40, 10, 10)
                       .angle()
                       .title("Кут_2")
                       .range(-15, 0, 5)
               .limitations()
                   .angleLimitation()
                       .title("Йоу")
                       .title("Кут")
                       .range(">20", "<100")
                       .range(">30", "<120")
                   .and()
                   .powerLimitation()
                       .range(">20")
                       .range("<20", ">120")
                   .or()
                   .powerLimitation()
                        .range(">0")
               .end();

            var driver = DriverBuilder
                .driver()
                    .calculateDistance()
                    .scriptAnalysis()
                    .buildTable(script)
                    .end();

            for (int j = 0; j < driver.combinations.Values.ToList()[0].Count; j++)
            {
                Console.WriteLine(driver.combinations.Values.ToList()[0][j] +
                    " " + driver.combinations.Values.ToList()[1][j] +
                    " " + driver.combinations.Values.ToList()[2][j] +
                    " " + (driver.combinations.Values.ToList()[3][j] as Lidar).LidarTitle +
                    " " + (driver.combinations.Values.ToList()[4][j] as Observer).ObserverTitle +
                    " " + (driver.combinations.Values.ToList()[5][j] as Coefficient).CoefficientTitle +
                    " " + (driver.combinations.Values.ToList()[6][j] as Phantom).PhantomTitle +
                    " " + (driver.combinations.Values.ToList()[7][j] as Polygon).PolygonTitle);
            }

            //foreach (Coefficient item in scene.Coefficients)
            //{
            //    Console.WriteLine(item.CoefficientTitle);
            //    foreach (var intenralItem in item.FrequencyValues)
            //    {
            //        Console.WriteLine(intenralItem);
            //    }
            //}
            //Console.WriteLine();
            //foreach (Angle item in script.Angles)
            //{
            //    Console.WriteLine(item.angleTitle);
            //    Console.WriteLine(item.angleRange["angleFrom"]);
            //    Console.WriteLine(item.angleRange["angleTo"]);
            //    Console.WriteLine(item.angleRange["step"]);
            //    Console.WriteLine();
            //}
            //Console.WriteLine("-----------------------");
            //foreach (Object item in script.Limitations.LimitationsCollection)
            //{
            //    if (item is AngleLimitation)
            //    {
            //        Console.WriteLine((item as AngleLimitation).angleTitle);
            //        Console.WriteLine((item as AngleLimitation).angleTitle);
            //        Console.WriteLine((item as AngleLimitation).angleLimitationRange[0]);
            //        if ((item as AngleLimitation).angleLimitationRange.Count == 2)
            //        {
            //            Console.WriteLine((item as AngleLimitation).angleLimitationRange[1]);
            //        }
            //    }
            //    if (item is PowerLimitation)
            //    {
            //        Console.WriteLine((item as PowerLimitation).powerLimitationRange[0]);
            //        if ((item as PowerLimitation).powerLimitationRange.Count == 2)
            //        {
            //            Console.WriteLine((item as PowerLimitation).powerLimitationRange[1]);
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine((script.BaseScene as Scene).Lidars[0].LidarTitle);
            Console.ReadKey();
        }
    }
}
