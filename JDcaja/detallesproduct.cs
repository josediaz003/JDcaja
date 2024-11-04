using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDcaja
{
    public class Completarfactura
    {
        public List<detallesfacturas> detallesfacturas { get; set; }
        public string toke_usuario { get; set; }
        public string cliente { get; set; }
        public float totalpago { get; set; }
        public int idestatus { get; set; }

    }
    public class detallesfacturas
    {
        public int idfactura { get; set; }
        public string producto { get; set; }
        public float precio { get; set; }
        public string cantidad { get; set; }
        public float totalpago { get; set; }
        public string estatus { get; set; }
        public string NombreProducto { get; set; }
    }
    public class cobrarfactura
    {
        public List<detallesfacturas> detallesfacturas { get; set; }
        public string toke_usuario { get; set; }
        public int idfactura { get; set; }

    }

}
