﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseModel.ScriptBaseModel
{
    public class PowerLimitation
    {
        public List<string> powerLimitationRange { get; set; }

        public PowerLimitation()
        {
            powerLimitationRange = new List<string>();
        }
    }
}
