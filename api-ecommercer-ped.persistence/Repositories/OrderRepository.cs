using api_ecommercer_ped.domain.Entities;
using api_ecommercer_ped.domain.Interfaces;
using api_ecommercer_ped.persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.persistence.Repositories
{
    public class OrderRepository : BaseRepository<OrderEntity>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<OrderEntity> CancelOrder(Guid id, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
            if (order != null)
            {
                order.Status = StatusPedido.Cancelled;
                _context.Orders.Update(order);
            }                

            return order;
        }


        public async Task<OrderEntity> CreateOrder(OrderEntity order, CancellationToken cancellationToken)
        {
            order.Status = StatusPedido.Pending;
            var items = order.Items;
            order.Items = new List<OrderItemEntity>();

            await _context.Orders.AddAsync(order, cancellationToken);

            foreach (var item in items)
            {
                item.OrderId = order.Id;
                await _context.OrderItems.AddAsync(item, cancellationToken);
                order.Items.Add(item);
            }

            return order;
        }

        public async Task<OrderEntity> GetOrder(Guid id, CancellationToken cancellationToken)
        {
            var order = await _context.Orders.FirstOrDefaultAsync(u => u.Id == id, cancellationToken);
            if (order != null)
                order = new OrderEntity();
            return order;
        }


        public async Task<List<OrderEntity>> ListOrder(int page, int pageSize, CancellationToken cancellationToken)
        {
            var orders = await _context.Orders.ToListAsync(cancellationToken);
            return orders;
        }

    }
}
