using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Services.Queries.DTOs
{
    public class ProductoDto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioUnitarioProducto { get; set; }
        public int pkidEstacion_tblEstacion { get; set; }
    }
}
