using api_ecommercer_ped.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.domain.Interfaces
{
    public interface IOrderRepository : IBaseRepository<OrderEntity>
    {
        Task<OrderEntity> CreateOrder(OrderEntity order, CancellationToken cancellationToken);
        Task<List<OrderEntity>> ListOrder(int page, int pageSize, CancellationToken cancellationToken);
        Task<OrderEntity> GetOrder(Guid id, CancellationToken cancellationToken);
        Task<OrderEntity> CancelOrder(Guid id, CancellationToken cancellationToken);
    }
}
