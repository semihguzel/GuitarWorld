using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld.DATA
{
    public class Guitar
    {
        public int GuitarID { get; set; }
        public int GuitarModelID { get; set; }
        public int GuitarTypeID { get; set; }
        public int SupplierID { get; set; }
        public string GuitarName { get; set; }
        public string GuitarColor { get; set; }
        public decimal  GuitarPrice { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string GuitarPicture1 { get; set; }
        public string GuitarPicture2 { get; set; }
        public string GuitarPicture3 { get; set; }
        public string GuitarPicture4 { get; set; }

        public virtual GuitarType GuitarType { get; set; }
        public virtual GuitarModel GuitarModel { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }




    }
}
