using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem()
        {
            IsPerson = true;
            IsBuyer = true;
            IsActive = true;
        }

        public int Id { get; set; } // IdUser

        // Para agentes externos
        public Guid IdWeb { get; set; }

        // public int IdOrder { get; set; }

        public string DNI { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        // Para marcar si es o no persona (si no empresa)
        public bool IsPerson { get; set; }

        // Para marcar si es o no comprador (si no admin)
        public bool IsBuyer { get; set; }

        // Para marcar si está o no activo el usuario
        public bool IsActive { get; set; }

        public int IdRol { get; set; }

        // private string EncryptedPassword { get; set; }

        //public DateTime BirthDay { get; set; }
        //public DateTime InsertDate { get; set; }
        //public DateTime UpdateDate { get; set; }
    }
}