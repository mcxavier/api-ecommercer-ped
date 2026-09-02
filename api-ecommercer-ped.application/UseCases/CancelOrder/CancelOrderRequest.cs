using api_ecommercer_ped.application.UseCases.CreateOrder;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace api_ecommercer_ped.application.UseCases.CancelOrder
{
    public sealed record CancelOrderRequest(Guid Id) :
        IRequest<CancelOrderResponse>;
}
