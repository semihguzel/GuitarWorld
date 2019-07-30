using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DATA
{
    public class GuitarModel
    {
        public int GuitarModelID { get; set; }
        public int GuitarBrandID { get; set; }
        public string GuitarModelName { get; set; }

        public virtual GuitarBrand GuitarBrand { get; set; }
        public virtual List<Guitar> Guitars { get; set; }
    }
}
