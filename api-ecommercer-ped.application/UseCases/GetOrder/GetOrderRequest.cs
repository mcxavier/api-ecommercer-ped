using api_ecommercer_ped.application.UseCases.CreateOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.GetOrder
{
    public sealed record GetOrderRequest(Guid id) :
        IRequest<GetOrderResponse>;
}
