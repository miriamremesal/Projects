using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class BuyerItem : UserItem
    {
        public BuyerItem()
        {
            IsActive = true;
        }

        // SUSTITUIR BUYERNAME POR FULLNAME DE USER ?¿
        // REFERENCIAR COMO EL ID DE USER (BUYERITEM.FULLNAME)
        public string BuyerName { get; set; }
        public bool IsActive { get; private set; }
        
        //MARCOS: public int IdRol { get; set; }
        //MARCOS: private string EncryptedPassword { get; set; }
        // Marcos lo tenía solo en mi comprador (su user), yo he preferido ponerlo en mi user (su person)

        //MIO: public int IdBuyer { get; set; }
        //MIO: public int IdUser { get; set; } aquí sabe si es persona o empresa el comprador
        //MIO: public int IdOrder { get; set; } aquí localiza el pedido realizado

        public string Address { get; set; }
        public string City { get; set; }
    }
}