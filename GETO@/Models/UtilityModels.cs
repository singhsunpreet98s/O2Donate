using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GETO_.Models
{
    public class Rootobject
    {
        public bool error { get; set; }
        public string msg { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public string name { get; set; }
        public string iso3 { get; set; }
        public State[] states { get; set; }
    }

    public class State
    {
        public string name { get; set; }
        public string state_code { get; set; }
    }
    public class States
    {
        public State[] states { get; set; }
    }


}
