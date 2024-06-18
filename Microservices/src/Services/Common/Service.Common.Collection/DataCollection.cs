using System.Collections.Generic;
using System.Linq;

namespace Services.Common.Collection
{
    //funciona para traer operaciones adicionales basada en la clase que recibe
    public class DataCollection<T>
    {
        public bool HasItems
        {
            get
            {
                return Items != null && Items.Any();
            }
        }

        public IEnumerable<T> Items { get; set; }
        public int Total { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
    }
}
