using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseModel;
using BaseModel.ScriptBaseModel;

namespace InternalDSL.ScriptClasses
{
    public class AnglesCollectionBuilder
    {
        public ScriptBuilder parent;
        public AnglesCollectionBuilder(ScriptBuilder parent)
        {
            this.parent = parent;
        }
        public AngleBuilder angle()
        {
            parent.baseScript.Angles.Add(new Angle());
            return new AngleBuilder(this);
        }
        public LimitationBuilder limitations()
        {
            return parent.limitations();
        }
        public Script end()
        {
            return this.parent.end();
        }
    }
}
