using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.domain.Entities
{

    public enum StatusPedido
    {
        Pending = 1,
        Confirmed = 2,
        Cancelled = 3
    }

    public sealed class OrderEntity : BaseEntity
    {
        public Guid CustomerId { get; set; }
        public StatusPedido Status { get; set; }
        public List<OrderItemEntity> Items { get; set; } = new List<OrderItemEntity>();
    }

}
