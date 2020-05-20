using QuickBuy.Dominio.ValueObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Order : Entity
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int UserId { get; set; }

        // data para previsão de entrega
        public DateTime DeliveryForecastDate { get; set; }

        public string CEP { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public int NumberAddress { get; set; }

        // informações da forma de pagamento
        public int FormPaymentId { get; set; }

        public FormPayment FormPayment { get; set; }

        // pedido pode ter N itens
        public ICollection<OrderItem> OrderItens { get; set; }

        public override void Validate()
        {
            ClearValidationMessage();

            if (!OrderItens.Any())
                AddValidationMessage("Pedido deve ter itens para existir");

            if (string.IsNullOrEmpty(CEP))
                AddValidationMessage("CEP deve ser preenchido");
        }
    }
}
