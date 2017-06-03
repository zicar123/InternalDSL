using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;
using BaseModel.ScriptBaseModel;

namespace InternalDSL.ScriptClasses
{
    public class AngleBuilder
    {
        public AnglesCollectionBuilder parent;
        public AngleBuilder(AnglesCollectionBuilder parent)
        {
            this.parent = parent;
        }
        public AngleBuilder title(string angleTitle)
        {
            this.parent.parent.baseScript.Angles.Last().angleTitle = angleTitle;
            return this;
        }
        public AngleBuilder range(int angleFrom, int angleTo, int step)
        {
            //Очистка коллекции для предотвращения накопления данных;
            this.parent.parent.baseScript.Angles.Last().angleRange =
                new Dictionary<string, int>() { { "angleFrom", 0 }, { "angleTo", 0 }, { "step", 0 } };
            this.parent.parent.baseScript.Angles.Last().angleRange["angleFrom"] = angleFrom;
            this.parent.parent.baseScript.Angles.Last().angleRange["angleTo"] = angleTo;
            this.parent.parent.baseScript.Angles.Last().angleRange["step"] = step;
            return this;
        }
        public AngleBuilder angle()
        {
            return this.parent.angle();
        }
        public LimitationBuilder limitations()
        {
            return this.parent.limitations();
        }
        public Script end()
        {
            return this.parent.end();
        }
    }
}
