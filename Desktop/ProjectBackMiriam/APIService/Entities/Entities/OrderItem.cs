using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {
            IsPaid = false;
            IsDelivered = false;
        }

        public int Id { get; set; } // IdOrder

        // Para agentes externos
        public Guid IdWeb { get; set; }

        // XQ MARCOS NO LO TIENE ?¿ public int IdBuyer { get; set; } // o IdUser

        public int ProductId { get; set; }

        // Para marcar si está o no cobrado
        public bool IsPaid { get; set; }

        // Para marcar si está pendiente de entregar o entregado
        public bool IsDelivered { get; set; }

        // Fecha en la que se realiza el pedido
        public DateTime OrderDate { get; set; }

        // Fecha en la que se entrega el pedido
        public DateTime DeliveryDate { get; set; }

        //public int Amount { get; set; }
        
    }
}