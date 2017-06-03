using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;
using BaseModel.ScriptBaseModel;

namespace InternalDSL.ScriptClasses
{
    public class AngleLimitationBuilder
    {
        public LimitationBuilder parent;
        public AngleLimitationBuilder(LimitationBuilder parent)
        {
            this.parent = parent;
        }
        public LimitationBuilder and()
        {
            this.parent.parent.baseScript.Limitations.OperatorsCollection.Add("and");
            return this.parent;
        }
        public LimitationBuilder or()
        {
            this.parent.parent.baseScript.Limitations.OperatorsCollection.Add("or");
            return this.parent;
        }
        public AngleLimitationBuilder title(string angleTitle)
        {
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleTitle = angleTitle;
            return this;
        }
        public AngleLimitationBuilder range(string from, string to)
        {
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleLimitationRange.Clear();
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleLimitationRange.Add(from);
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleLimitationRange.Add(to);
            return this;
        }
        public AngleLimitationBuilder range(string rangeValue)
        {
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleLimitationRange.Clear();
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as AngleLimitation).angleLimitationRange.Add(rangeValue);
            return this;
        }
        public Script end()
        {
            return this.parent.end();
        }
    }
}
