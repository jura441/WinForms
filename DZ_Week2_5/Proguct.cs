using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Week2_5
{
    public class Proguct
    {
        public string Name { get; set; }
        public string Characters { get; set; }
        public string Desc { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return Name + " " + Characters + " " + Desc;
        }
    }
}
