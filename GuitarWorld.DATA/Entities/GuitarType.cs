using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DATA
{
    public class GuitarType
    {
        public int GuitarTypeID { get; set; }
        public string GuitarTypeName { get; set; }

        public virtual List<Guitar> Guitars { get; set; }
    }
}
