
using Microsoft.EntityFrameworkCore;
using Productos.Persistence.Database;
using Productos.Services.Queries.DTOs;
using Services.Common.Collection;
using Services.Common.Mapping;
using Services.Common.Paging



namespace Productos.Services.Querys
{
    public class ProductoQueryServices
    {
        private readonly ApplicationDbContext _context;
        public ProductoQueryServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DataCollection<ProductoDto>> ObtenerTodoAsync(int page, int take, IEnumerable<int> products = null)
        {
            var collection = await _context.Productos
                .Where(x => products == null || products.Contains(x.IdProducto))
                .OrderBy(x => x.NombreProducto)
                .GetPagedAsync(page, take);

            return collection.MapTo<DataCollection<ProductoDto>>();
        }

        public async Task<ProductoDto> ObtenerAsync(int id)
        {
            return (await _context.Productos.SingleAsync(x => x.IdProducto == id)).MapTo<ProductoDto>();
        }
    }
}
