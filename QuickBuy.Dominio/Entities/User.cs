using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        // usuário pode ter N pedidos
        public ICollection<Order> Orders { get; set; }
    }
}
