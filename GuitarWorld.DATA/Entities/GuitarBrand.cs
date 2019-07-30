using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DATA
{
    public class GuitarBrand
    {
        public int GuitarBrandID { get; set; }
        public string GuitarBrandName { get; set; }

        public virtual List<GuitarModel> GuitarModels { get; set; }
    }
}
