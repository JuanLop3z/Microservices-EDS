using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Productos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productos.Persistence.Database.Configuration
{
    public class ProductoConfiguration
    {
        //configuracion personalizada de mi clase en el entity framework
        public ProductoConfiguration(EntityTypeBuilder<Producto> entityTypeBuilder)
        {
            //Se agrega como tipo id
            entityTypeBuilder.HasKey(x => x.IdProducto);
            entityTypeBuilder.Property(x => x.NombreProducto).IsRequired().HasMaxLength(100);
            entityTypeBuilder.Property(x => x.PrecioUnitarioProducto).IsRequired().HasMaxLength(50);

            var productos = new List<Producto>();
            var ramdon = new Random();

            for (var i = 1; i <= 100; i++)
            {
                productos.Add(new Producto
                {
                    IdProducto = i,
                    NombreProducto = $"Producto {i}",
                    PrecioUnitarioProducto = ramdon.Next(100, 1000),
                    pkidEstacion_tblEstacion = ramdon.Next(100, 1000)
                });
            }
            entityTypeBuilder.HasData(productos);
        }
    }
}
