using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.domain.Entities
{
    public sealed class OrderItemEntity : BaseEntity
    {
        public Guid OrderId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnityPrice { get; set; }
    }
}
