using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class ProductItem
    {
        public ProductItem()
        {
            IsActive = true;
            IsPublic = true;
        }
        public int Id { get; set; } // IdProduct

        // Para agentes externos
        public Guid IdWeb { get; set; }

        // public int IdOrder { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        // Para marcar si está o no público (si está ya a la venta)
        public bool IsPublic { get; private set; }

        // Para marcar si hay o no stock disponible
        public bool IsActive { get; private set; }


        // public DateTime InsertDate { get; set; }
        // public DateTime? UpdateDate { get; set; }
    }
}
