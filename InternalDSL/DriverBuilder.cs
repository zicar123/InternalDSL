using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;

namespace InternalDSL
{
    public class DriverBuilder
    {
        private Driver baseDriver;
        public DriverBuilder(Driver baseDriver)
        {
            this.baseDriver = baseDriver;
        }
        public DriverBuilder()
        {
            this.baseDriver = new Driver();
        }
        public DriverBuilder buildTable(Script script)
        {
            var tempArray = new List<Object>();
            var commonArray = new List<Object[]>();
            var arrayTitles = new List<string>();
            foreach (var angle in script.Angles)
            {
                for (int counter = angle.angleRange["angleFrom"]; counter < angle.angleRange["angleTo"]; counter += angle.angleRange["step"])
                {
                    tempArray.Add(counter.ToString());
                }
                arrayTitles.Add(angle.angleTitle);
                commonArray.Add(tempArray.ToArray());
                tempArray.Clear();
            }
            arrayTitles.AddRange(new List<string>() { "ЛІДАРИ", "СПОСТЕРІГАЧИ", "КОЕФІЦІЄНТИ", "ФАНТОМИ", "ПОЛІГОНИ" });
            commonArray.Add((script.BaseScene as Scene).Lidars.ToArray());
            commonArray.Add((script.BaseScene as Scene).Observers.ToArray());
            commonArray.Add((script.BaseScene as Scene).Coefficients.ToArray());
            commonArray.Add((script.BaseScene as Scene).Phantoms.ToArray());
            commonArray.Add((script.BaseScene as Scene).Polygons.ToArray());
            baseDriver.combinations = Merge(commonArray.ToArray(), arrayTitles);
            return this;
        }
        private static Dictionary<string, List<Object>> Merge(Object[][] arr, List<string> titles)
        {
            //Конечный результат;
            Dictionary<string, List<Object>> list = new Dictionary<string, List<Object>>();
            //Количество копий каждого элемента каждой коллекции;
            int copiesCount = 1;
            foreach (var item in arr)
                copiesCount *= item.Count();
            //Переформатирование исходных массивов в результирующие коллекции;
            for (int i = 0; i < arr.Count(); i++)
                list.Add(titles[i], GetList(copiesCount, i, arr));
            var temp = new List<Object>();
            //Адаптация всех массивов под один размер;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list.Values.ToList()[i].Count < list.Values.ToList()[0].Count)
                {
                    temp = list.Values.ToList()[i].ToList();
                    for (int j = 1; j < list.Values.ToList()[0].Count / temp.Count; j++)
                    {
                        list.Values.ToList()[i].AddRange(temp);
                    }
                }
            }
            return list;
        }
        private static List<Object> GetList(int copiesCount, int indexOfArray, Object[][] arr)
        {
            List<Object> list = new List<Object>();
            //Определение количества повторений каждого элемента текущего массива; 
            for (int i = indexOfArray; i >= 0; i--)
                copiesCount /= arr[i].Count();
            //Клонирование элементов (создание новой коллекции с учётом повторений);
            for (int j = 0; j < arr[indexOfArray].Count(); j++)
                for (int i = 0; i < copiesCount; i++)
                    list.Add(arr[indexOfArray][j]);
            return list;
        }
        public Driver end()
        {
            return baseDriver;
        }
        public static DriverBuilder driver()
        {
            return new DriverBuilder();
        }
        public DriverBuilder scriptAnalysis()
        {
            return this;
        }
        public DriverBuilder calculate()
        {
            return this;
        }
        public DriverBuilder calculateDistance()
        {
            return this;
        }
    }
}