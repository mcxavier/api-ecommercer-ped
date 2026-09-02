using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit(CancellationToken cancellationToken);
    }
}
