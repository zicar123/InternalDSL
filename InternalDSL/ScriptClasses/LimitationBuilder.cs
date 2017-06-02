using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModelScript;

namespace InternalDSL.ScriptClasses
{
    public class LimitationBuilder
    {
        public ScriptBuilder parent;
        public LimitationBuilder(ScriptBuilder parent)
        {
            this.parent = parent;
        }
        public AngleLimitationBuilder angleLimitation()
        {
            this.parent.baseScript.Limitations.LimitationsCollection.Add(new AngleLimitation());
            return new AngleLimitationBuilder(this);
        }
        public PowerLimitationBuilder powerLimitation()
        {
            this.parent.baseScript.Limitations.LimitationsCollection.Add(new PowerLimitation());
            return new PowerLimitationBuilder(this);
        }
        public Script end()
        {
            return this.parent.end();
        }
    }
}
