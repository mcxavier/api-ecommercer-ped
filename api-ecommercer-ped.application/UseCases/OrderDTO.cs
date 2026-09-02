using api_ecommercer_ped.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases
{
    public record OrderDTO
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public StatusPedido Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }

    public sealed record OrderItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal UnityPrice { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
        public DateTimeOffset? DeletedAt { get; set; }
    }



}
