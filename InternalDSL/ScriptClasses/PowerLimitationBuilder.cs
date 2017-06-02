using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelScript;

namespace InternalDSL.ScriptClasses
{
    public class PowerLimitationBuilder
    {
        public LimitationBuilder parent;
        public PowerLimitationBuilder(LimitationBuilder parent)
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
        public PowerLimitationBuilder range(string from, string to)
        {
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as PowerLimitation).powerLimitationRange.Clear();
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as PowerLimitation).powerLimitationRange.Add(from);
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as PowerLimitation).powerLimitationRange.Add(to);
            return this;
        }
        public PowerLimitationBuilder range(string rangeValue)
        {
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as PowerLimitation).powerLimitationRange.Clear();
            (this.parent.parent.baseScript.Limitations.LimitationsCollection.Last() as PowerLimitation).powerLimitationRange.Add(rangeValue);
            return this;
        }
        public Script end()
        {
            return this.parent.end();
        }
    }
}
