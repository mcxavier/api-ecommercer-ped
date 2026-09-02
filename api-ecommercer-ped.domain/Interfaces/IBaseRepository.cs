using api_ecommercer_ped.domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid Id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
