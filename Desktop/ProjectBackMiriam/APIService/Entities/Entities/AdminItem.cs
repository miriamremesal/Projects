using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class AdminItem : UserItem
    {
        public AdminItem()
        {
            IsActive = true;
        }

        // SUSTITUIR ADMINNAME POR FULLNAME DE USER ?¿
        // REFERENCIAR COMO EL ID DE USER (ADMINITEM.FULLNAME) 
        public string AdminName { get; set; }
        public bool IsActive { get; private set; }


        //MARCOS: public int IdRol { get; set; }
        //MARCOS: private string EncryptedPassword { get; set; }
        // Marcos lo tenía solo en mi comprador (su user), yo he preferido ponerlo en mi user (su person)

        //MIO: public int IdAdmin { get; set; }

        //MIO: public int IdUser { get; set; } aquí sabe si es persona o empresa el comprador

        //MIO: public string CompanyName { get; set; } solo si fuera empresa, en vd el name de User vale

        //MARCOS: public int CompanyId { get; set; }
    }
}
