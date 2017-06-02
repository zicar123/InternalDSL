using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternalDSL.ScriptClasses;
using BaseModelScript;

namespace InternalDSL
{
    public class ScriptBuilder
    {
        public Script baseScript;
        public ScriptBuilder()
        {
            this.baseScript = new Script();
        }
        public ScriptBuilder scene(Object baseScene)
        {
            this.baseScript.BaseScene = baseScene;
            return this;
        }
        public AnglesCollectionBuilder angles()
        {
            return new AnglesCollectionBuilder(this);
        }
        public LimitationBuilder limitations()
        {
            return new LimitationBuilder(this);
        }
        public Script end()
        {
            return this.baseScript;
        }
        public static ScriptBuilder script()
        {
            return new ScriptBuilder();
        }
    }
}
