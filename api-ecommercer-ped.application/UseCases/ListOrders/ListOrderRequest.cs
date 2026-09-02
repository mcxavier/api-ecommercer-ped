using api_ecommercer_ped.application.UseCases.CreateOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.ListOrders
{
    public sealed record ListOrderRequest(int page, int pageSize) :
        IRequest<ListOrderResponse>;
}
